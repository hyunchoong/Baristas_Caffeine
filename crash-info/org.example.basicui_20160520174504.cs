S/W Version Information
Model: SM-R735S
Tizen-Version: 2.3.1.4
Build-Number: R735SKSU1BPD1
Build-Date: 2016.04.06 15:13:39

Crash Information
Process Name: basicui
PID: 10146
Date: 2016-05-20 17:45:04+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 6
      (SIGABRT)
      si_code: 0
      signal sent by kill (sent by pid 961, uid 0)

Register Information
r0   = 0xfffffffc, r1   = 0x00000002
r2   = 0xb5b2d084, r3   = 0x00000000
r4   = 0xb57f2189, r5   = 0x404636e3
r6   = 0xbee67f48, r7   = 0x0000001d
r8   = 0x00000041, r9   = 0xb6bdf824
r10  = 0xb73dd700, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbee67cf8
lr   = 0xb6ec76d8, pc   = 0xb6ec8b60
cpsr = 0x80000010

Memory Information
MemTotal:   407572 KB
MemFree:     15108 KB
Buffers:     13064 KB
Cached:     104028 KB
VmPeak:      81468 KB
VmSize:      79304 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15000 KB
VmRSS:       15000 KB
VmData:      21620 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23192 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 10146 TID = 10146
10146 10169 10170 

Maps Information
b2440000 b24c7000 rw-s anon_inode:dmabuf
b24c7000 b254e000 rw-s anon_inode:dmabuf
b254e000 b25d5000 rw-s anon_inode:dmabuf
b25d5000 b265c000 rw-s anon_inode:dmabuf
b265d000 b2e5c000 rwxp [stack:10170]
b2e5d000 b365c000 rwxp [stack:10169]
b387a000 b3891000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b389e000 b38a0000 r-xp /usr/lib/libgenlock.so
b38be000 b38c3000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b38cb000 b38d6000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3c10000 b3cda000 r-xp /usr/lib/libCOREGL.so.4.0
b3ceb000 b3cf4000 r-xp /usr/lib/libresourced.so.0.2.86
b3cfc000 b3cfd000 r-xp /usr/lib/librd-network.so.0.2.86
b3d05000 b3d12000 r-xp /usr/lib/libail.so.0.1.0
b3d1b000 b3d22000 r-xp /usr/lib/libminizip.so.1.0.0
b3d2a000 b3d2c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3d34000 b3d3b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3d44000 b3d60000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3d69000 b3d71000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b3d79000 b3d7f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b3d87000 b3d8c000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b3d94000 b3db5000 r-xp /usr/lib/libexif.so.12.3.3
b3dc8000 b3de1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b3de9000 b3dee000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3df6000 b3dfb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b538b000 b538d000 r-xp /usr/lib/libdri2.so.0.0.0
b5395000 b539d000 r-xp /usr/lib/libdrm.so.2.4.0
b53a5000 b53a6000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b53af000 b53b2000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b53ba000 b549e000 r-xp /usr/lib/libicuuc.so.51.1
b54b3000 b55f0000 r-xp /usr/lib/libicui18n.so.51.1
b5600000 b5606000 r-xp /usr/lib/libxcb-render.so.0.0.0
b560e000 b560f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5618000 b561b000 r-xp /usr/lib/libEGL.so.1.4
b5623000 b5631000 r-xp /usr/lib/libGLESv2.so.2.0
b563a000 b5641000 r-xp /usr/lib/libtbm.so.1.0.0
b5649000 b566a000 r-xp /usr/lib/libui-extension.so.0.1.0
b5673000 b5685000 r-xp /usr/lib/libtts.so
b568d000 b5694000 r-xp /usr/lib/libsensord-share.so
b569c000 b5754000 r-xp /usr/lib/libcairo.so.2.11200.14
b575f000 b5771000 r-xp /usr/lib/libefl-assist.so.0.1.0
b5779000 b5797000 r-xp /usr/lib/libsensor.so.1.1.0
b57a1000 b57a6000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b57ae000 b57cf000 r-xp /usr/lib/libefl-extension.so.0.1.0
b57d7000 b57db000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b57e4000 b57e9000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b57f1000 b57f4000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b599d000 b59a7000 r-xp /lib/libnss_files-2.13.so
b59b0000 b5a7f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5a95000 b5ab9000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5ac2000 b5ac8000 r-xp /usr/lib/libappsvc.so.0.1.0
b5ad0000 b5ad2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5adb000 b5adf000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5aeb000 b5af6000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5afe000 b5b00000 r-xp /usr/lib/libiniparser.so.0
b5b09000 b5b0e000 r-xp /usr/lib/libappcore-common.so.1.1
b5b17000 b5b1f000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b5b20000 b5b24000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b31000 b5b33000 r-xp /usr/lib/libXau.so.6.0.0
b5b3c000 b5b43000 r-xp /lib/libcrypt-2.13.so
b5b73000 b5b75000 r-xp /usr/lib/libiri.so
b5b7d000 b5d25000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d3e000 b5d8b000 r-xp /usr/lib/libssl.so.1.0.0
b5d98000 b5dc6000 r-xp /usr/lib/libidn.so.11.5.44
b5dce000 b5dd7000 r-xp /usr/lib/libcares.so.2.1.0
b5de0000 b5df3000 r-xp /usr/lib/libxcb.so.1.1.0
b5dfc000 b5dfe000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e07000 b5e09000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e12000 b5ede000 r-xp /usr/lib/libxml2.so.2.7.8
b5eeb000 b5eed000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5ef5000 b5efa000 r-xp /usr/lib/libffi.so.5.0.10
b5f02000 b5f03000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f0c000 b5f17000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f1f000 b5f22000 r-xp /lib/libattr.so.1.1.0
b5f2a000 b5fbe000 r-xp /usr/lib/libstdc++.so.6.0.16
b5fd1000 b5fee000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5ff6000 b600e000 r-xp /usr/lib/libpng12.so.0.50.0
b6017000 b602d000 r-xp /lib/libexpat.so.1.5.2
b6037000 b607b000 r-xp /usr/lib/libcurl.so.4.3.0
b6084000 b608e000 r-xp /usr/lib/libXext.so.6.4.0
b6097000 b609b000 r-xp /usr/lib/libXtst.so.6.1.0
b60a3000 b60a9000 r-xp /usr/lib/libXrender.so.1.3.0
b60b2000 b60b8000 r-xp /usr/lib/libXrandr.so.2.2.0
b60c0000 b60c1000 r-xp /usr/lib/libXinerama.so.1.0.0
b60ca000 b60d3000 r-xp /usr/lib/libXi.so.6.1.0
b60db000 b60de000 r-xp /usr/lib/libXfixes.so.3.1.0
b60e6000 b60e8000 r-xp /usr/lib/libXgesture.so.7.0.0
b60f0000 b60f2000 r-xp /usr/lib/libXcomposite.so.1.0.0
b60fb000 b60fd000 r-xp /usr/lib/libXdamage.so.1.1.0
b6105000 b610c000 r-xp /usr/lib/libXcursor.so.1.0.2
b6114000 b6117000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b611f000 b6123000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b612c000 b6131000 r-xp /usr/lib/libecore_fb.so.1.7.99
b613b000 b621c000 r-xp /usr/lib/libX11.so.6.3.0
b6227000 b624a000 r-xp /usr/lib/libjpeg.so.8.0.2
b6262000 b6278000 r-xp /lib/libz.so.1.2.5
b6280000 b62f5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b62ff000 b6315000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b631e000 b6352000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b635b000 b642e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6439000 b6449000 r-xp /lib/libresolv-2.13.so
b644d000 b64c9000 r-xp /usr/lib/libgcrypt.so.20.0.3
b64d5000 b64ed000 r-xp /usr/lib/liblzma.so.5.0.3
b64f6000 b64f9000 r-xp /lib/libcap.so.2.21
b6501000 b652c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6534000 b6535000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b653d000 b6543000 r-xp /usr/lib/libecore_imf.so.1.7.99
b654b000 b6562000 r-xp /usr/lib/liblua-5.1.so
b656c000 b6573000 r-xp /usr/lib/libembryo.so.1.7.99
b657b000 b6581000 r-xp /lib/librt-2.13.so
b658a000 b65e0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b65ed000 b6643000 r-xp /usr/lib/libfreetype.so.6.11.3
b664f000 b6677000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6679000 b66b6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66bf000 b66d2000 r-xp /usr/lib/libfribidi.so.0.3.1
b66da000 b66f4000 r-xp /usr/lib/libecore_con.so.1.7.99
b66fd000 b6706000 r-xp /usr/lib/libedbus.so.1.7.99
b670e000 b675e000 r-xp /usr/lib/libecore_x.so.1.7.99
b6761000 b6765000 r-xp /usr/lib/libvconf.so.0.2.45
b676d000 b677e000 r-xp /usr/lib/libecore_input.so.1.7.99
b6786000 b678b000 r-xp /usr/lib/libecore_file.so.1.7.99
b6793000 b67b5000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67be000 b67ff000 r-xp /usr/lib/libeina.so.1.7.99
b6808000 b6821000 r-xp /usr/lib/libeet.so.1.7.99
b6832000 b689b000 r-xp /lib/libm-2.13.so
b68a4000 b68aa000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68b3000 b68b6000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68be000 b68e0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b68e8000 b68ed000 r-xp /usr/lib/libxdgmime.so.1.1.0
b68f5000 b691f000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6928000 b693f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6947000 b6952000 r-xp /lib/libunwind.so.8.0.1
b697f000 b69bb000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c4000 b6adf000 r-xp /lib/libc-2.13.so
b6aed000 b6af5000 r-xp /lib/libgcc_s-4.6.so.1
b6af6000 b6af9000 r-xp /usr/lib/libsmack.so.1.0.0
b6b01000 b6b07000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b0f000 b6bdf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6be0000 b6c3d000 r-xp /usr/lib/libedje.so.1.7.99
b6c47000 b6c5e000 r-xp /usr/lib/libecore.so.1.7.99
b6c75000 b6d43000 r-xp /usr/lib/libevas.so.1.7.99
b6d68000 b6ea3000 r-xp /usr/lib/libelementary.so.1.7.99
b6eb9000 b6ecd000 r-xp /lib/libpthread-2.13.so
b6ed8000 b6eda000 r-xp /usr/lib/libdlog.so.0.0.0
b6ee2000 b6ee5000 r-xp /usr/lib/libbundle.so.0.1.22
b6eed000 b6eef000 r-xp /lib/libdl-2.13.so
b6ef8000 b6f04000 r-xp /usr/lib/libaul.so.0.1.0
b6f16000 b6f1b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f24000 b6f28000 r-xp /usr/lib/libsys-assert.so
b6f31000 b6f4e000 r-xp /lib/ld-2.13.so
b6f57000 b6f5c000 r-xp /usr/bin/launchpad-loader
b72ed000 b74b2000 rw-p [heap]
bee48000 bee69000 rwxp [stack]
bee48000 bee69000 rwxp [stack]
End of Maps Information

Callstack Information (PID:10146)
Call Stack Count: 2
 0: pause + 0x40 (0xb6ec8b60) [/lib/libpthread.so.0] + 0xfb60
 1: on_sensor_event + 0x506 (0xb57f268f) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x168f
End of Call Stack

Package Information
Package Name: org.example.basicui
Package ID : org.example.basicui
Version: 1.0.0
Package Type: rpm
App Name: basicui
App ID: org.example.basicui
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
969+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7765): preference.c: preference_get_int(1132) > preference_get_int(7765) : key(music-control-service_native/playing_diration) error
05-20 17:44:56.969+0900 W/MUSIC_CONTROL_SERVICE( 7765): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:7765]   preference_get_int() .. [0xfef00030][0m
05-20 17:44:56.969+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:56.969+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:56.969+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:56.969+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-20 17:44:56.969+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-20 17:44:56.969+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:56.969+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.windicator:music-control-service-message-port]
05-20 17:44:56.969+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:56.979+0900 I/APP_CORE( 1130): appcore-efl.c: __do_app(429) > [APP 1130] Event: RESUME State: PAUSED
05-20 17:44:56.979+0900 I/CAPI_APPFW_APPLICATION( 1130): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.windicator:music-control-service-message-port]
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:56.979+0900 W/W_INDICATOR( 1130): windicator_message_port.c: _music_service_messageport_cb(112) > [_music_service_messageport_cb:112] msg_id:music-playstatechanged-ind remote app id:com.samsung.w-music-player.music-control-service
05-20 17:44:56.979+0900 W/W_INDICATOR( 1130): windicator_message_port.c: _music_service_messageport_cb(119) > [_music_service_messageport_cb:119] mode:local state:paused 
05-20 17:44:56.979+0900 I/TIZEN_N_SOUND_MANAGER( 7765): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
05-20 17:44:56.979+0900 W/TIZEN_N_SOUND_MANAGER( 7765): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.windicator:music-control-service-message-port]
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.windicator:music-control-service-message-port]
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-20 17:44:56.979+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:56.979+0900 W/W_INDICATOR( 1130): windicator_message_port.c: _music_service_messageport_cb(112) > [_music_service_messageport_cb:112] msg_id:music-volumechanged-ind remote app id:com.samsung.w-music-player.music-control-service
05-20 17:44:56.989+0900 I/CAPI_WATCH_APPLICATION( 7742): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-20 17:44:57.319+0900 W/W_HOME  ( 1195): event_manager.c: _ecore_x_message_cb(415) > moment bar move:1
05-20 17:44:57.319+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:57.349+0900 E/W_INDICATOR( 1130): windicator_util.c: _ecore_event_client_message_cb(1091) > [_ecore_event_client_message_cb:1091] quickpanel 1
05-20 17:44:57.349+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.349+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-20 17:44:57.359+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.359+0900 E/CAPI_APPFW_APP_CONTROL( 7765): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-20 17:44:57.359+0900 W/MUSIC_CONTROL_SERVICE( 7765): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:7765]   [com.samsung.w-home]register msg port [true][0m
05-20 17:44:57.359+0900 W/AUL_AMD (  960): amd_request.c: __request_handler(646) > __request_handler: 14
05-20 17:44:57.359+0900 W/AUL_AMD (  960): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1130
05-20 17:44:57.359+0900 W/AUL_AMD (  960): amd_request.c: __request_handler(646) > __request_handler: 14
05-20 17:44:57.369+0900 W/AUL_AMD (  960): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1195
05-20 17:44:57.379+0900 W/MUSIC_CONTROL_SERVICE( 7765): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:7765]   [MUSIC_PLAYER_EVENT][0m
05-20 17:44:57.379+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7765): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
05-20 17:44:57.379+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7765): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
05-20 17:44:57.379+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7765): preference.c: preference_get_int(1132) > preference_get_int(7765) : key(music-control-service_native/playing_diration) error
05-20 17:44:57.379+0900 W/MUSIC_CONTROL_SERVICE( 7765): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:7765]   preference_get_int() .. [0xfef00030][0m
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-20 17:44:57.379+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.379+0900 W/W_HOME  ( 1195): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
05-20 17:44:57.379+0900 E/W_HOME  ( 1195): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-20 17:44:57.389+0900 W/MUSIC_CONTROL_SERVICE( 7765): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:7765]   [MUSIC_PLAYER_EVENT][0m
05-20 17:44:57.389+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7765): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
05-20 17:44:57.389+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7765): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
05-20 17:44:57.389+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7765): preference.c: preference_get_int(1132) > preference_get_int(7765) : key(music-control-service_native/playing_diration) error
05-20 17:44:57.389+0900 W/MUSIC_CONTROL_SERVICE( 7765): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:7765]   preference_get_int() .. [0xfef00030][0m
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-20 17:44:57.389+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.389+0900 W/W_HOME  ( 1195): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
05-20 17:44:57.389+0900 E/W_HOME  ( 1195): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-20 17:44:57.399+0900 I/TIZEN_N_SOUND_MANAGER( 7765): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
05-20 17:44:57.399+0900 W/TIZEN_N_SOUND_MANAGER( 7765): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-20 17:44:57.399+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.459+0900 E/EFL     (  644): <644> e_mod_processmgr.c:495 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
05-20 17:44:57.639+0900 I/W_INDICATOR( 1130): windicator_connection.c: _wifi_state_changed_cb(745) > [_wifi_state_changed_cb:745] wifi state : 2
05-20 17:44:57.639+0900 W/W_INDICATOR( 1130): windicator_connection.c: _connection_icon_set(565) > [_connection_icon_set:565] type : 12 / signal : type_wifi_connected_03
05-20 17:44:57.639+0900 E/W_INDICATOR( 1130): windicator_connection.c: _connection_icon_set(587) > [_connection_icon_set:587] Set Connection / show sw.icon_1 (type : 12) / (hide : 0)
05-20 17:44:57.639+0900 E/W_INDICATOR( 1130): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
05-20 17:44:57.639+0900 W/W_INDICATOR( 1130): windicator_connection.c: _packet_icon_set(669) > [_packet_icon_set:669] packet : 0 / signal : packet_no_inout_connected
05-20 17:44:57.649+0900 I/W_INDICATOR( 1130): windicator_connection.c: _wifi_state_changed_cb(745) > [_wifi_state_changed_cb:745] wifi state : 2
05-20 17:44:57.649+0900 W/W_INDICATOR( 1130): windicator_connection.c: _connection_icon_set(565) > [_connection_icon_set:565] type : 12 / signal : type_wifi_connected_03
05-20 17:44:57.649+0900 E/W_INDICATOR( 1130): windicator_connection.c: _connection_icon_set(587) > [_connection_icon_set:587] Set Connection / show sw.icon_1 (type : 12) / (hide : 0)
05-20 17:44:57.649+0900 E/W_INDICATOR( 1130): windicator_connection.c: _packet_type_changed_cb(970) > [_packet_type_changed_cb:970] WIFI MODE
05-20 17:44:57.649+0900 W/W_INDICATOR( 1130): windicator_connection.c: _packet_icon_set(669) > [_packet_icon_set:669] packet : 3 / signal : packet_inout_connected
05-20 17:44:57.689+0900 E/W_INDICATOR( 1130): windicator_util.c: _ecore_event_client_message_cb(1113) > [_ecore_event_client_message_cb:1113] quickpanel 0
05-20 17:44:57.689+0900 E/W_INDICATOR( 1130): windicator_util.c: _ecore_event_client_message_cb(960) > [_ecore_event_client_message_cb:960] quickpanel is closed
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.689+0900 E/CAPI_APPFW_APP_CONTROL( 7765): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-20 17:44:57.689+0900 W/W_INDICATOR( 1130): windicator_message_port.c: _mp_messageport_register(324) > [_mp_messageport_register:324] Used message-port
05-20 17:44:57.689+0900 I/MESSAGE_PORT( 1130): MessagePortProxy.cpp: IsLocalPortRegisted(675) > MessagePort name is already registered.
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.windicator:music-control-service-message-port], client = 1130
05-20 17:44:57.689+0900 I/MESSAGE_PORT(  879): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-20 17:44:57.689+0900 W/W_HOME  ( 1195): event_manager.c: _ecore_x_message_cb(415) > moment bar move:0
05-20 17:44:57.689+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:57.689+0900 W/MUSIC_CONTROL_SERVICE( 7765): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:7765]   [com.samsung.windicator]register msg port [false][0m
05-20 17:44:57.689+0900 W/AUL_AMD (  960): amd_request.c: __request_handler(646) > __request_handler: 14
05-20 17:44:57.689+0900 E/W_INDICATOR( 1130): windicator_moment_bar.c: windicator_moment_bar_hide(1531) > [windicator_moment_bar_hide:1531] Hide Moment Bar : dynamic_layout(0xb8f4b690)
05-20 17:44:57.689+0900 I/efl-extension( 1130): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb8f33890, elm_layout, _activated_obj : 0x0, activated : 0
05-20 17:44:57.689+0900 I/efl-extension( 1130): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-20 17:44:57.689+0900 I/efl-extension( 1130): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb8f33890, elm_layout, func : 0xb6ef7639
05-20 17:44:57.689+0900 I/efl-extension( 1130): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-20 17:44:57.699+0900 W/AUL_AMD (  960): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1195
05-20 17:44:57.699+0900 W/PROCESSMGR(  644): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-20 17:44:57.709+0900 W/W_HOME  ( 1195): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-20 17:44:57.709+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:57.709+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:57.709+0900 W/WATCH_CORE( 7742): appcore-watch.c: __signal_process_manager_handler(1164) > process_manager_signal
05-20 17:44:57.709+0900 I/WATCH_CORE( 7742): appcore-watch.c: __signal_process_manager_handler(1180) > Call the time_tick_cb
05-20 17:44:57.709+0900 I/CAPI_WATCH_APPLICATION( 7742): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-20 17:44:57.709+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:57.709+0900 W/W_HOME  ( 1195): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 1
05-20 17:44:57.709+0900 I/GESTURE (  232): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-20 17:44:57.739+0900 I/APP_CORE( 1130): appcore-efl.c: __do_app(429) > [APP 1130] Event: PAUSE State: RUNNING
05-20 17:44:57.739+0900 I/CAPI_APPFW_APPLICATION( 1130): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-20 17:44:57.999+0900 I/CAPI_WATCH_APPLICATION( 7742): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-20 17:44:58.159+0900 W/STARTER ( 1128): hw_key.c: _key_press_cb(1206) > [_key_press_cb:1206] POWER Key is pressed
05-20 17:44:58.159+0900 W/STARTER ( 1128): hw_key.c: _key_press_cb(1209) > [_key_press_cb:1209] LCD state : 1
05-20 17:44:58.159+0900 W/STARTER ( 1128): hw_key.c: _key_press_cb(1216) > [_key_press_cb:1216] PM state : 1
05-20 17:44:58.159+0900 W/STARTER ( 1128): hw_key.c: _key_press_cb(1230) > [_key_press_cb:1230] powerkey count : 1
05-20 17:44:58.349+0900 W/STARTER ( 1128): hw_key.c: _key_release_cb(1130) > [_key_release_cb:1130] POWER Key is released
05-20 17:44:58.609+0900 W/STARTER ( 1128): hw_key.c: _powerkey_timer_cb(812) > [_powerkey_timer_cb:812] _powerkey_timer_cb, powerkey count[1]
05-20 17:44:58.609+0900 W/STARTER ( 1128): hw_key.c: _powerkey_timer_cb(967) > [_powerkey_timer_cb:967] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
05-20 17:44:58.629+0900 E/STARTER ( 1128): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-20 17:44:58.629+0900 W/AUL_AMD (  960): amd_request.c: __request_handler(646) > __request_handler: 0
05-20 17:44:58.629+0900 W/AUL_AMD (  960): amd_launch.c: _start_app(1702) > caller pid : 1128
05-20 17:44:58.639+0900 W/AUL_AMD (  960): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 1195
05-20 17:44:58.639+0900 I/APP_CORE( 1195): appcore-efl.c: __do_app(429) > [APP 1195] Event: RESET State: RUNNING
05-20 17:44:58.639+0900 I/CAPI_APPFW_APPLICATION( 1195): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-20 17:44:58.639+0900 W/W_HOME  ( 1195): main.c: _app_control(1737) > Service value : powerkey
05-20 17:44:58.639+0900 I/wnotib  ( 1195): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x40001
05-20 17:44:58.639+0900 E/wnotib  ( 1195): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4494) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-20 17:44:58.639+0900 E/wnotib  ( 1195): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-20 17:44:58.639+0900 W/W_HOME  ( 1195): noti_broker.c: _noti_broker_home_cb(786) > continue the home key execution
05-20 17:44:58.639+0900 E/W_HOME  ( 1195): cs_broker.c: _cs_broker_home_cb(256) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
05-20 17:44:58.639+0900 W/W_HOME  ( 1195): move.c: move_move_to_apps(216) > move to apps
05-20 17:44:58.639+0900 W/W_HOME  ( 1195): rotary.c: rotary_attach(138) > rotary_attach:0xb8f170d0
05-20 17:44:58.639+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb8f170d0, elm_layout, _activated_obj : 0xb8d6ef98, activated : 1
05-20 17:44:58.639+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-20 17:44:58.639+0900 W/W_HOME  ( 1195): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-20 17:44:58.639+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:58.639+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:58.649+0900 W/AUL_AMD (  960): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(17), pid(1195), cmd(0)
05-20 17:44:58.649+0900 E/AUL     ( 1128): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-20 17:44:58.649+0900 E/AUL     (  960): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-20 17:44:58.659+0900 I/APP_CORE( 1195): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-20 17:44:58.659+0900 I/GESTURE (  232): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-20 17:44:58.659+0900 W/W_HOME  ( 1195): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-20 17:44:58.659+0900 W/W_HOME  ( 1195): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-20 17:44:58.659+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:58.669+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:58.669+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:58.669+0900 W/W_HOME  ( 1195): noti_broker.c: _apptray_visibility_cb(793) > apps,show,start
05-20 17:44:58.669+0900 W/W_HOME  ( 1195): noti_broker.c: noti_broker_event_fire_to_plugin(1011) > source:1 event:80002
05-20 17:44:58.669+0900 I/wnotib  ( 1195): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-20 17:44:58.669+0900 I/wnotib  ( 1195): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-20 17:44:58.939+0900 W/W_HOME  ( 1195): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-20 17:44:58.939+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-20 17:44:58.939+0900 W/W_HOME  ( 1195): rotary.c: rotary_deattach(156) > rotary_deattach:0xb8f170d0
05-20 17:44:58.939+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-20 17:44:58.939+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb8f170d0, elm_layout, func : 0xb6e7e709
05-20 17:44:58.949+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-20 17:44:58.949+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-20 17:44:58.949+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-20 17:44:58.949+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb8d6ef98, elm_box, _activated_obj : 0xb8f170d0, activated : 1
05-20 17:44:58.949+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-20 17:44:58.949+0900 E/wnotib  ( 1195): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-20 17:44:58.949+0900 I/wnotib  ( 1195): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 2, -1.
05-20 17:44:58.949+0900 I/wnotib  ( 1195): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-20 17:44:58.959+0900 W/W_HOME  ( 1195): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-20 17:44:58.959+0900 W/W_HOME  ( 1195): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-20 17:44:58.959+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-20 17:44:58.969+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-20 17:44:58.969+0900 W/W_HOME  ( 1195): main.c: home_pause(762) > clock/widget paused
05-20 17:44:58.969+0900 W/W_HOME  ( 1195): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-20 17:44:58.969+0900 W/APPS    ( 1195): apps_main.c: _time_changed_cb(295) >  date : 20->20
05-20 17:44:58.969+0900 W/W_HOME  ( 1195): rotary.c: rotary_attach(138) > rotary_attach:0xb8e30cb8
05-20 17:44:58.969+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb8e30cb8, elm_layout, _activated_obj : 0xb8d6ef98, activated : 1
05-20 17:44:58.969+0900 I/efl-extension( 1195): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-20 17:44:58.969+0900 W/W_HOME  ( 1195): noti_broker.c: _apptray_visibility_cb(793) > apps,show
05-20 17:44:58.969+0900 W/W_HOME  ( 1195): noti_broker.c: noti_broker_event_fire_to_plugin(1011) > source:1 event:80000
05-20 17:44:58.969+0900 I/wnotib  ( 1195): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-20 17:44:58.969+0900 E/wnotib  ( 1195): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-20 17:44:58.969+0900 I/wnotib  ( 1195): w-notification-board-panel-basic.c: _wnotib_basic_panel_close_second_depth_view(5438) > wnotib_action_drawer_hidden_get(): 1, page_popup: 0x0
05-20 17:44:58.969+0900 E/wnotib  ( 1195): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4494) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-20 17:44:58.969+0900 E/wnotib  ( 1195): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-20 17:44:58.969+0900 E/wnotib  ( 1195): w-notification-board-action-drawer.c: wnotib_action_drawer_is_available(4795) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-20 17:44:58.969+0900 I/wnotib  ( 1195): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1705) > is_app_tray_displayed: 1
05-20 17:44:58.969+0900 E/APPS    ( 1195): apps_main.c: apps_main_resume(627) >  resumed already
05-20 17:44:58.969+0900 I/GESTURE (  232): gesture.c: BackGestureSetProperty(4510) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-20 17:44:58.969+0900 I/GESTURE (  232): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-20 17:44:58.969+0900 I/GESTURE (  232): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-20 17:44:58.969+0900 I/GESTURE (  232): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-20 17:44:58.979+0900 W/WATCH_CORE( 7742): appcore-watch.c: __widget_pause(1002) > widget_pause
05-20 17:44:59.589+0900 I/GESTURE (  232): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-20 17:44:59.599+0900 W/APPS    ( 1195): AppsViewNecklace.cpp: touchPressed(1264) >  TOUCH [174, 173]
05-20 17:44:59.629+0900 W/APPS    ( 1195): AppsViewNecklace.cpp: touchReleased(1583) >  TOUCH [174, 173]->[174, 173]
05-20 17:44:59.629+0900 W/APPS    ( 1195): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,26]
05-20 17:44:59.629+0900 E/APPS    ( 1195): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-20 17:44:59.629+0900 W/APPS    ( 1195): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
05-20 17:44:59.629+0900 W/AUL_AMD (  960): amd_request.c: __request_handler(646) > __request_handler: 0
05-20 17:44:59.629+0900 W/AUL_AMD (  960): amd_launch.c: _start_app(1702) > caller pid : 1195
05-20 17:44:59.629+0900 I/AUL_AMD (  960): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-20 17:44:59.649+0900 W/AUL_AMD (  960): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 10146
05-20 17:44:59.649+0900 E/AUL     (  960): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-20 17:45:00.649+0900 W/AUL_AMD (  960): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-20 17:45:00.649+0900 W/AUL_AMD (  960): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-20 17:45:00.959+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7753): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-20 17:45:00.959+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7753): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-20 17:45:00.959+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7753): preference.c: preference_get_double(1214) > preference_get_double(7753) : pedometer_inactive_period error
05-20 17:45:00.959+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7753): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-20 17:45:00.959+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7753): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-20 17:45:00.959+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7753): preference.c: preference_get_double(1214) > preference_get_double(7753) : inactive_10min_precaution_millisec error
05-20 17:45:00.959+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7753): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-20 17:45:00.959+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7753): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-20 17:45:00.969+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 7753): preference.c: preference_get_double(1214) > preference_get_double(7753) : inactive_before_10min_precaution_millisec error
05-20 17:45:02.749+0900 I/APP_CORE( 1130): appcore-efl.c: __do_app(429) > [APP 1130] Event: MEM_FLUSH State: PAUSED
05-20 17:45:02.749+0900 I/GESTURE (  232): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-20 17:45:04.329+0900 I/efl-extension( 1674): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-20 17:45:04.449+0900 I/efl-extension( 1674): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-20 17:45:04.649+0900 E/AUL_AMD (  960): amd_launch.c: __recv_timeout_handler(935) > application is not responding : pid(10146) cmd(0)
05-20 17:45:04.649+0900 W/AUL_AMD (  960): amd_launch.c: __send_watchdog_signal(425) > send a watchdog signal done: 10146
05-20 17:45:04.659+0900 E/RESOURCED(  961): proc-monitor.c: proc_dbus_watchdog_handler(743) > [proc_dbus_watchdog_handler,743] Receive watchdog signal to pid: 10146(basicui)
05-20 17:45:04.659+0900 E/RESOURCED(  961): proc-monitor.c: proc_dbus_watchdog_handler(754) > [proc_dbus_watchdog_handler,754] just kill watchdog process when debug enabled pid: 10146(basicui)
05-20 17:45:04.659+0900 I/efl-extension( 1674): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-20 17:45:04.759+0900 I/efl-extension( 1674): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-20 17:45:04.819+0900 I/efl-extension( 1674): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-20 17:45:04.829+0900 E/AUL     ( 1195): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-20 17:45:04.829+0900 E/CAPI_APPFW_APP_CONTROL( 1195): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
05-20 17:45:04.859+0900 I/efl-extension( 1674): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-20 17:45:04.909+0900 W/APPS    ( 1195): AppsViewNecklace.cpp: touchPressed(1264) >  TOUCH [166, 180]
05-20 17:45:04.909+0900 W/APPS    ( 1195): AppsViewNecklace.cpp: touchReleased(1583) >  TOUCH [166, 180]->[166, 180]
05-20 17:45:04.909+0900 W/APPS    ( 1195): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,26]
05-20 17:45:04.909+0900 E/APPS    ( 1195): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-20 17:45:04.909+0900 W/APPS    ( 1195): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
05-20 17:45:04.919+0900 W/AUL_AMD (  960): amd_request.c: __request_handler(646) > __request_handler: 0
05-20 17:45:04.919+0900 W/AUL_AMD (  960): amd_launch.c: _start_app(1702) > caller pid : 1195
05-20 17:45:04.919+0900 I/AUL_AMD (  960): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-20 17:45:04.959+0900 E/RESOURCED(  961): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
05-20 17:45:04.959+0900 E/RESOURCED(  961): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-20 17:45:04.969+0900 W/CRASH_MANAGER(10233): worker.c: worker_job(1199) > 0610146626173146373390
