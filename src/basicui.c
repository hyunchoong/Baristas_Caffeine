#include <tizen.h>
#include <service_app.h>
#include <device/display.h>
#include <device/callback.h>
#include <math.h>
#include "basicui.h"
#define TAG "My_Caffeine"
#define N 0
#define S 1

int error_hrm, error_acc;
int state = 0;
float HRM = 0;
float Acc_X = 0;
float Acc_Y = 0;
float Acc_Z = 0;
int mode = 0;
float Acc1[500], Acc2[500];
float Var_HR[500];
float Mani_Acc[50];
float HR1[501], HR2[500];
float Mani_HR[50];
char hrm[80];
char status[80];


sensor_h sensor;
sensor_listener_h listener;

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label_hrm;
	Evas_Object *label_status;
	Evas_Object *grid_main;
	Evas_Object *btn_stop;
	Evas_Object *btn_pause;
	Evas_Object *btn_start;
} appdata_s;

static void
	clicked_stop(void *user_data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
	device_vibrate(int duration, int feedback) {
		haptic_device_h haptic_handle;
		haptic_effect_h effect_handle;

		if(device_haptic_open(0, &haptic_handle) == DEVICE_ERROR_NONE) {

			LOGI("Connection to vibrator established");

			if(device_haptic_vibrate(haptic_handle, duration, feedback, &effect_handle) == DEVICE_ERROR_NONE) {
				LOGI("Device vibrates!");
			}

			//		To stop vibration which are being played use below code with proper handles
			//		if(device_haptic_stop(haptic_handle, effect_handle) == DEVICE_ERROR_NONE) {
			//			LOGI("Device vibration stopped");
			//		}

			//		When you decided not to use haptic anymore disconnect it
			//		if(device_haptic_close(haptic_handle) == DEVICE_ERROR_NONE) {
			//			LOGI("Vibrator disconnected");
			//		}
		}
}

void on_sensor_event(sensor_h sensor, sensor_event_s *event, void *user_data)
{
	if(state == S){
		sleep(5);
	}
	// Use the sensor type, assuming there is only 1 sensor for each type
	sensor_type_e type;
	sensor_get_type(sensor, &type);
	switch (type) {
	case SENSOR_ACCELEROMETER:
		Acc_X = event->values[0];
		Acc_Y = event->values[1];
		Acc_Z = event->values[2];
		mode = 0;
		//       dlog_print(DLOG_INFO, TAG, "%s, %f, %f, %f", "",Acc_X, Acc_Y,Acc_Z);
		break;

	case SENSOR_HRM:
		HRM = event->values[0];
		mode = 1 ;
		break;
	}
	if(mode == 1){
		HR1[0] = HRM;
		float buff = sqrt(Acc_X * Acc_X + Acc_Y * Acc_Y + Acc_Z * Acc_Z) - 9.8;
		if(buff >= 0){
			Acc1[0] = buff;
		}
		else {
			Acc1[0] = -buff;
		}
		HR1[500] = HR1[499];
		for(int i = 0; i< 500; i++){
			Var_HR[i] = HR1[i] - HR1[i+1];
		}
		for(int i = 0; i < 500; i++){
			HR2[i+1] = HR1[i];
			Acc2[i+1] = Acc1[i];
		}
		for(int i = 0; i< 500; i++){
			HR1[i] = HR2[i];
			Acc1[i] = Acc2[i];
		}
		HR1[0] = 0; Acc1[0] = 0;
		float buf1[50];
		float buf2[50];
		for(int i = 0; i < 50; i++){
			buf1[i] = 0;
			buf2[i] = 0;
		}
		for(int i = 0 ; i < 50; i++){
			for(int j = 0; j < 10; j++){
				buf1[i] += Var_HR[j+10*i];
				Mani_HR[i] = buf1[i];
				buf2[i] += Acc1[j+10*i];
				Mani_Acc[i] = buf2[i] * 0.1;
			}
		}
		int Gap = 0;
		int Acc_Sum = 0;
		for (int i = 0; i < 50; i++){
			Gap += Var_HR[i];
			Acc_Sum += Mani_Acc[i];
		}
		if(Gap > -5){
			state = N;
		}
		else{
			if(Mani_Acc[0] > 0.153771){
				state = N;
			}
			else{
				if(Mani_Acc[5] > 0.125873){
					state = N;
				}
				else{
					if(Mani_HR[6] > -1){
						state = S;
					}
					else{
						if(Mani_HR[35] > -1){
							state = S;
						}
						else{
							state = N;
						}
					}
				}
			}
		}
		appdata_s *ad = user_data;

		if(state == N){
			sprintf(status, "Status: AWAKE");
			evas_object_color_set(ad->label_status, 0, 255, 0, 255);
		}
		else {
			sprintf(status, "    Status: SLEEP");
			evas_object_color_set(ad->label_status, 255, 0, 0, 255);
			device_vibrate(5000,100);
		}

		elm_object_text_set(ad->label_status, status);

		sprintf(hrm, "HRM: %0.2f", HRM);
		elm_object_text_set(ad->label_hrm, hrm);
	}
}

static void
	win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
	win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void
	create_base_gui(appdata_s *ad)
{
	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	ad->grid_main = elm_grid_add(ad->conform);
	elm_object_content_set(ad->conform, ad->grid_main);
	evas_object_show(ad->grid_main);

	ad->label_hrm = elm_label_add(ad->grid_main);
	elm_object_text_set(ad->label_hrm, hrm);
	elm_grid_pack(ad->grid_main, ad->label_hrm, 26, 23, 60, 10);
	evas_object_show(ad->label_hrm);

	ad->label_status = elm_label_add(ad->grid_main);
	elm_object_text_set(ad->label_status, hrm);
	evas_object_color_set(ad->label_status, 0, 255, 0, 255);
	elm_grid_pack(ad->grid_main, ad->label_status, 20, 38, 60, 10);
	evas_object_show(ad->label_status);

	ad->btn_stop = elm_button_add(ad->grid_main);
	elm_object_text_set(ad->btn_stop, "close");
	elm_grid_pack(ad->grid_main, ad->btn_stop, 34, 70, 35, 10);
	evas_object_show(ad->btn_stop);
	evas_object_smart_callback_add(ad->btn_stop, "clicked", clicked_stop, ad);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static bool
	app_create(void *data)
{
	appdata_s *ad = data;
	create_base_gui(ad);

	HR1[500] = 0;
	for(int i = 0; i < 500; i++){
		Acc1[i] = 0;
		Acc2[i] = 0;
		HR1[i] = 0;
		HR2[i] = 0;
		Var_HR[i] = 0;
	}
	for(int i = 0; i < 50 ; i++){
		Mani_Acc[i] = 0;
		Mani_HR[i] = 0;
	}
	sensor_type_e type_hrm = SENSOR_HRM;
	sensor_type_e type_acc = SENSOR_ACCELEROMETER;
	bool supported;

	error_hrm = sensor_is_supported(type_hrm, &supported);
	if(error_hrm == SENSOR_ERROR_NONE ) {
		error_hrm = sensor_get_default_sensor(type_hrm, &sensor);
		error_hrm = sensor_create_listener(sensor, &listener);
		error_hrm = sensor_listener_set_option(listener, SENSOR_OPTION_ALWAYS_ON);
		error_hrm = sensor_listener_start(listener);
		error_hrm = sensor_listener_set_event_cb(listener, 100, on_sensor_event, data);
	}

	error_acc = sensor_is_supported(type_acc, &supported);
	if(error_acc == SENSOR_ERROR_NONE ) {
		error_acc = sensor_get_default_sensor(type_acc, &sensor);
		error_acc = sensor_create_listener(sensor, &listener);
		error_acc = sensor_listener_set_option(listener, SENSOR_OPTION_ALWAYS_ON);
		error_acc = sensor_listener_start(listener);
		error_acc = sensor_listener_set_event_cb(listener, 100, on_sensor_event, data);
	}
	/* Hook to take necessary actions before main event loop starts
	Initialize UI resources and application's data
	If this function returns true, the main loop of application starts
	If this function returns false, the application is terminated */

	return true;
}

static void
	app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
	app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
	app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
	app_terminate(void *data)
{
	/* Release all resources. */
}

static void
	ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
	ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
	ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
	ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
	ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}


int
	main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
