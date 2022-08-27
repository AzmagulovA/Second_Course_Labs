#ifndef DELETEWINDOW_H
#define DELETEWINDOW_H

#include <QDialog>
#include <QSqlQuery>
#include <QSqlTableModel>
namespace Ui {
class Deletewindow;
}

class Deletewindow : public QDialog
{
    Q_OBJECT

public:
    explicit Deletewindow(QWidget *parent = nullptr);
    ~Deletewindow();

private slots:
    void on_DeleteB_clicked();

private:
    Ui::Deletewindow *ui;
      QSqlDatabase db;
};

#endif // DELETEWINDOW_H
