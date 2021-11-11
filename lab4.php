<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
<form method="POST">
    <input type="submit" name="name4" value="Добавление т."/>
    <input type="submit" name="name1" value="Редактирование т."/>
    <input type="submit" name="name2" value="Удаление т."/>
    <input type="submit" name="name3" value="Select"/>
    <input type="submit" name="name5" value="Insert"/>
    <input type="submit" name="name6" value="Update"/>
    <input type="submit" name="name7" value="Delete"/>
    <input type="submit" name="name8" value="Inner Join"/>
    <script>
        function ClickFunction (){
            alert("Вы нажали на кнопку");
        }
    </script>

</form>
<table border="1">
    <?php

    $servername="localhost";
    $username="root";
    $password="";
    $dbname="lab4";

    $conn= new mysqli($servername,$username,$password,$dbname);

    if($conn->connect_error){
        die("Connection failed".$conn->connect_error);
    }




    if ( isset($_POST['name1']))      //Запрос 1
    {
        $sql =('ALTER TABLE STAFF
ADD Email varchar(255);');
        if (mysqli_query($conn, $sql)) {
            echo "Таблица STAFF изменена успешно";
        } else {
            echo "Ошибка изменения таблицы: " . mysqli_error($conn);
        }
    }
    else if ( isset($_POST['name2'])) //Запрос 2
    {
        $sql=('DROP TABLE STAFF');
        if (mysqli_query($conn, $sql)) {
            echo "Таблица STAFF удалена успешно";
        } else {
            echo "Ошибка удаления таблицы: " . mysqli_error($conn);
        }

    }
    else if ( isset($_POST['name7'])) //Запрос 7
    {
        $sql=('DELETE FROM STAFF;');
        if (mysqli_query($conn, $sql)) {
            echo "Таблица STAFF очищенна от данных  успешно";
        } else {
            echo "Ошибка очищения таблицы: " . mysqli_error($conn);
        }

    }
    else if ( isset($_POST['name6'])) //Запрос 6
    {
        $sql=('UPDATE STAFF
SET duration_of_work = duration_of_work + 1;');
        if (mysqli_query($conn, $sql)) {
            echo "Стаж работы сотрудников увеличен на год";
        } else {
            echo "Увеличить стаж работы сотрудников не получилось:  " . mysqli_error($conn);
        }

    }
    else if ( isset($_POST['name5'])) //Запрос 5
    {
        $sql =("INSERT INTO STAFF (FIO, telephone,salary,addres,duration_of_work) 
VALUES ('Азмагулов Артём Вадимович', 88005553535,1,'ул.Луговая 35',2)
");
        $sql2=("INSERT INTO STAFF (FIO, telephone,salary,addres,duration_of_work) 
VALUES ('Азмагулов Артур Вадимович', 88005553536,1,'ул.Луговая 36',3)");
        mysqli_query($conn, $sql2);
        $sql3=("INSERT INTO STAFF (FIO, telephone,salary,addres,duration_of_work) 
VALUES ('Азмагулов Ашот Вадимович', 88005553537,2,'ул.Полевая 36',4);");
        mysqli_query($conn, $sql3);
        $sql4=("INSERT INTO STAFF (FIO, telephone,salary,addres,duration_of_work) 
VALUES ('Азмагулов Алеша Вадимович', 88005553538,3,'ул.Лесная 37',5);");
        mysqli_query($conn, $sql4);
        $sql5=("INSERT INTO STAFF (FIO, telephone,salary,addres,duration_of_work) 
VALUES ('Азмагулов Абоба Вадимович', 88005553539,1,'ул.Озерная 38',6);");
        mysqli_query($conn, $sql5);


        if (mysqli_query($conn, $sql)) {
            echo "Добавление элементов прошло успешно";
        } else {
            echo "Ошибка Добавление элементов : " . mysqli_error($conn);
        }



    }
    else if ( isset($_POST['name3'])) //Запрос 3
    {
        $sql = ('SELECT FIO, duration_of_work,telephone,salary,addres FROM STAFF where duration_of_work > 4');

        $result=mysqli_query($conn,$sql);
        $table = "<table border=1 width = '600px' align=left>";

        $table .= "<td >".'FIO'."</td>";
        $table .= "<td >".'telephone'."</td>";
        $table .= "<td >".'salary'."</td>";
        $table .= "<td >".'addres'."</td>";
        $table .= "<td >".'duration_of_work'."</td>";
        $table .= "</tr>";
        while($row=$result->fetch_assoc()) {


            $table .= "<td >".$row['FIO']."</td>";
            $table .= "<td >".$row['telephone']."</td>";
            $table .= "<td >".$row['salary']."</td>";
            $table .= "<td >".$row['addres']."</td>";
            $table .= "<td >".$row['duration_of_work']."</td>";

            $table .= "</tr>";
        }
        $table .= "</table>";
        echo $table;
    }
    else if ( isset($_POST['name8'])) //Запрос 7
    {
        $sql =('SELECT FIO, telephone,addres,duration_of_work,salary_m FROM STAFF INNER JOIN mon on id_pos = salary');
        $result=mysqli_query($conn,$sql);
        $table = "<table border=1 width = '600px' align=left>";

        $table .= "<td >".'FIO'."</td>";
        $table .= "<td >".'telephone'."</td>";
        $table .= "<td >".'salary_m'."</td>";
        $table .= "<td >".'addres'."</td>";
        $table .= "<td >".'duration_of_work'."</td>";
        $table .= "</tr>";
        while($row=$result->fetch_assoc()) {


            $table .= "<td >".$row['FIO']."</td>";
            $table .= "<td >".$row['telephone']."</td>";
            $table .= "<td >".$row['salary_m']."</td>";
            $table .= "<td >".$row['addres']."</td>";
            $table .= "<td >".$row['duration_of_work']."</td>";

            $table .= "</tr>";
        }
        $table .= "</table>";
        echo $table;
    }
    else if ( isset($_POST['name4'])) {//Запрос 4
        $sql = "CREATE TABLE STAFF(

FIO Varchar(30),
telephone bigint,
salary int unsigned,
addres Varchar(30),
duration_of_work int unsigned
)";
        if (mysqli_query($conn, $sql)) {
            echo "Таблица STAFF создана успешно";
        } else {
            echo "Ошибка создания таблицы: " . mysqli_error($conn);
        }
    }
    $conn->close;


    ?>
</table>

</body>
</html>