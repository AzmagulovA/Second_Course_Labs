/********************************************************************************
** Form generated from reading UI file 'connectcodes.ui'
**
** Created by: Qt User Interface Compiler version 6.2.4
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_CONNECTCODES_H
#define UI_CONNECTCODES_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QDialog>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QTableView>

QT_BEGIN_NAMESPACE

class Ui_ConnectCodes
{
public:
    QGridLayout *gridLayout;
    QPushButton *AddB;
    QPushButton *DeleteB;
    QPushButton *UpdateTableB;
    QTableView *DatabaseTableView;

    void setupUi(QDialog *ConnectCodes)
    {
        if (ConnectCodes->objectName().isEmpty())
            ConnectCodes->setObjectName(QString::fromUtf8("ConnectCodes"));
        ConnectCodes->resize(621, 505);
        gridLayout = new QGridLayout(ConnectCodes);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        AddB = new QPushButton(ConnectCodes);
        AddB->setObjectName(QString::fromUtf8("AddB"));

        gridLayout->addWidget(AddB, 1, 0, 1, 1);

        DeleteB = new QPushButton(ConnectCodes);
        DeleteB->setObjectName(QString::fromUtf8("DeleteB"));

        gridLayout->addWidget(DeleteB, 1, 1, 1, 1);

        UpdateTableB = new QPushButton(ConnectCodes);
        UpdateTableB->setObjectName(QString::fromUtf8("UpdateTableB"));

        gridLayout->addWidget(UpdateTableB, 1, 2, 1, 1);

        DatabaseTableView = new QTableView(ConnectCodes);
        DatabaseTableView->setObjectName(QString::fromUtf8("DatabaseTableView"));

        gridLayout->addWidget(DatabaseTableView, 0, 0, 1, 3);


        retranslateUi(ConnectCodes);

        QMetaObject::connectSlotsByName(ConnectCodes);
    } // setupUi

    void retranslateUi(QDialog *ConnectCodes)
    {
        ConnectCodes->setWindowTitle(QCoreApplication::translate("ConnectCodes", "Dialog", nullptr));
        AddB->setText(QCoreApplication::translate("ConnectCodes", "\320\224\320\276\320\261\320\260\320\262\320\270\321\202\321\214", nullptr));
        DeleteB->setText(QCoreApplication::translate("ConnectCodes", "\320\243\320\264\320\260\320\273\320\270\321\202\321\214", nullptr));
        UpdateTableB->setText(QCoreApplication::translate("ConnectCodes", "\320\236\320\261\320\275\320\276\320\262\320\270\321\202\321\214", nullptr));
    } // retranslateUi

};

namespace Ui {
    class ConnectCodes: public Ui_ConnectCodes {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_CONNECTCODES_H
