#ifndef __basicui_H__
#define __basicui_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <device/haptic.h>

#include <dlog.h>			//Tizen Log
#include <message_port.h>	//Tizen Message port
#include <sensor.h>			//Tizen Sensor API
#include <stdio.h>			//File I/O (fopen)
#include <string.h>			//String
#include <sys/types.h>		//General data type
#include <sys/stat.h>		//File I/O (mkdir)
#include <time.h>			//Timer function
#include <unistd.h>			//Access function

#ifdef  TAG
#undef  TAG
#endif
#define TAG "basicui"
#include <tizen.h>			//Tizen

#if !defined(PACKAGE)
#define PACKAGE "org.example.basicui"
#endif

#endif /* __basicui_H__ */
