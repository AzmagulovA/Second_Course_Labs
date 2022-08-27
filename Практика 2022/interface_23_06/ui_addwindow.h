/********************************************************************************
** Form generated from reading UI file 'addwindow.ui'
**
** Created by: Qt User Interface Compiler version 6.2.4
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_ADDWINDOW_H
#define UI_ADDWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QDialog>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPushButton>

QT_BEGIN_NAMESPACE

class Ui_AdminWindow
{
public:
    QLineEdit *CodeAddLineEdit;
    QLabel *label;
    QLabel *label_2;
    QLineEdit *CountConnectLineEdit;
    QPushButton *AddNewCodeB;
    QPushButton *RandomStrB;
    QLabel *WarningLabel;

    void setupUi(QDialog *AdminWindow)
    {
        if (AdminWindow->objectName().isEmpty())
            AdminWindow->setObjectName(QString::fromUtf8("AdminWindow"));
        AdminWindow->resize(405, 298);
        CodeAddLineEdit = new QLineEdit(AdminWindow);
        CodeAddLineEdit->setObjectName(QString::fromUtf8("CodeAddLineEdit"));
        CodeAddLineEdit->setGeometry(QRect(160, 70, 113, 22));
        label = new QLabel(AdminWindow);
        label->setObjectName(QString::fromUtf8("label"));
        label->setGeometry(QRect(10, 70, 101, 16));
        label_2 = new QLabel(AdminWindow);
        label_2->setObjectName(QString::fromUtf8("label_2"));
        label_2->setGeometry(QRect(10, 110, 141, 16));
        CountConnectLineEdit = new QLineEdit(AdminWindow);
        CountConnectLineEdit->setObjectName(QString::fromUtf8("CountConnectLineEdit"));
        CountConnectLineEdit->setGeometry(QRect(160, 110, 113, 22));
        AddNewCodeB = new QPushButton(AdminWindow);
        AddNewCodeB->setObjectName(QString::fromUtf8("AddNewCodeB"));
        AddNewCodeB->setGeometry(QRect(320, 90, 75, 24));
        RandomStrB = new QPushButton(AdminWindow);
        RandomStrB->setObjectName(QString::fromUtf8("RandomStrB"));
        RandomStrB->setGeometry(QRect(280, 70, 31, 24));
        WarningLabel = new QLabel(AdminWindow);
        WarningLabel->setObjectName(QString::fromUtf8("WarningLabel"));
        WarningLabel->setGeometry(QRect(10, 150, 181, 16));

        retranslateUi(AdminWindow);

        QMetaObject::connectSlotsByName(AdminWindow);
    } // setupUi

    void retranslateUi(QDialog *AdminWindow)
    {
        AdminWindow->setWindowTitle(QCoreApplication::translate("AdminWindow", "Dialog", nullptr));
        label->setText(QCoreApplication::translate("AdminWindow", "\320\232\320\276\320\264\320\237\320\276\320\264\320\272\320\273\321\216\321\207\320\265\320\275\320\270\321\217", nullptr));
        label_2->setText(QCoreApplication::translate("AdminWindow", "\320\232\320\276\320\273\320\270\321\207\320\265\321\201\321\202\320\262\320\276\320\237\320\276\320\264\320\272\320\273\321\216\321\207\320\265\320\275\320\270\320\271", nullptr));
        AddNewCodeB->setText(QCoreApplication::translate("AdminWindow", "\320\224\320\276\320\261\320\260\320\262\320\270\321\202\321\214", nullptr));
        RandomStrB->setText(QCoreApplication::translate("AdminWindow", "R", nullptr));
        WarningLabel->setText(QCoreApplication::translate("AdminWindow", "TextLabel", nullptr));
    } // retranslateUi

};

namespace Ui {
    class AdminWindow: public Ui_AdminWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_ADDWINDOW_H
