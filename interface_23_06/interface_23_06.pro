QT       += core gui sql network

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

CONFIG += c++17

# You can make your code fail to compile if it uses deprecated APIs.
# In order to do so, uncomment the following line.
#DEFINES += QT_DISABLE_DEPRECATED_BEFORE=0x060000    # disables all the APIs deprecated before Qt 6.0.0

SOURCES += \
    addwindow.cpp \
    autorization.cpp \
    connectcodes.cpp \
    deletewindow.cpp \
    main.cpp

HEADERS += \
    addwindow.h \
    autorization.h \
    connectcodes.h \
    deletewindow.h

FORMS += \
    addwindow.ui \
    autorization.ui \
    connectcodes.ui \
    deletewindow.ui

# Default rules for deployment.
qnx: target.path = /tmp/$${TARGET}/bin
else: unix:!android: target.path = /opt/$${TARGET}/bin
!isEmpty(target.path): INSTALLS += target
