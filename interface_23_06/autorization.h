#ifndef AUTORIZATION_H
#define AUTORIZATION_H

#include <QDialog>
#include <QDebug>
#include <QSqlQuery>
#include <QSqlTableModel>
namespace Ui {
class Autorization;
}

class Autorization : public QDialog
{
    Q_OBJECT

public:
    explicit Autorization(QWidget *parent = nullptr);
    ~Autorization();
    void closeEvent(QCloseEvent *event);

private slots:
    void on_ConnectB_clicked();


private:
    Ui::Autorization *ui;
    QSqlDatabase db;


};

#endif // AUTORIZATION_H
