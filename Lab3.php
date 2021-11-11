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
    <input type="submit" name="name4" value="Вся таблица"/>
   <input type="submit" name="name1" value="запрос1"/>
    <input type="submit" name="name2" value="запрос2"/>
    <input type="submit" name="name3" value="запрос3"/>
    
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
$dbname="lab3";

$conn= new mysqli($servername,$username,$password,$dbname);

if($conn->connect_error){
    die("Connection failed".$conn->connect_error);
}




if ( isset($_POST['name1']))      //Запрос 1
{
    $sql =('SELECT FIO, Telephone, Salary, Addres FROM employees');
    $result=mysqli_query($conn,$sql);
    $table = "<table border=1 width = '600px' align=left>";

    $table .= "<td >".'FIO'."</td>";
    $table .= "<td >".'Telephone'."</td>";
    $table .= "<td >".'Salary'."</td>";
    $table .= "<td >".'Addres'."</td>";
    $table .= "</tr>";
    while($row=$result->fetch_assoc()) {


        $table .= "<td >".$row['FIO']."</td>";
        $table .= "<td >".$row['Telephone']."</td>";
        $table .= "<td >".$row['Salary']."</td>";
        $table .= "<td >".$row['Addres']."</td>";

        $table .= "</tr>";
    }
    $table .= "</table>";
    echo $table;
}

else if ( isset($_POST['name2'])) //Запрос 2
{
    $sql=('SELECT FIO, Addres FROM employees ORDER BY Addres');
    $result=mysqli_query($conn,$sql);
    $table = "<table border=1 width = '400px' align=left>";

    $table .= "<td >".'FIO'."</td>";
    $table .= "<td >".'Addres'."</td>";
    $table .= "</tr>";
    while($row=$result->fetch_assoc()) {


        $table .= "<td >".$row['FIO']."</td>";
        $table .= "<td >".$row['Addres']."</td>";

        $table .= "</tr>";
    }
    $table .= "</table>";
    echo $table;

}
else if ( isset($_POST['name3'])) //Запрос 3
{
    $sql = ('SELECT FIO, duration_of_work FROM employees where duration_of_work > 4');

    $result=mysqli_query($conn,$sql);
    $table = "<table border=1 width = '400px' align=left>";
    $table .= "<td >".'FIO'."</td>";
    $table .= "<td >".'duration_of_work'."</td>";
    $table .= "</tr>";
    while($row=$result->fetch_assoc()) {


        $table .= "<td >".$row['FIO']."</td>";
        $table .= "<td >".$row['duration_of_work']."</td>";

        $table .= "</tr>";
    }
    $table .= "</table>";
    echo $table;
}
else if ( isset($_POST['name4'])) {//Запрос 4
    $sql = ('SELECT * FROM `employees`');
    $result=mysqli_query($conn,$sql);
    $table = "<table border=1 width = '600px' align=left>";
    $table .= "<td >".'FIO'."</td>";
    $table .= "<td >".'Telephone'."</td>";
    $table .= "<td >".'Salary'."</td>";
    $table .= "<td >".'Addres'."</td>";
    $table .= "<td >".'duration_of_work'."</td>";
    $table .= "</tr>";

while($row=$result->fetch_assoc()) {
   $table .= "<td >".$row['FIO']."</td>";
    $table .= "<td >".$row['Telephone']."</td>";
    $table .= "<td >".$row['Salary']."</td>";
    $table .= "<td >".$row['Addres']."</td>";
    $table .= "<td >".$row['duration_of_work']."</td>";
    $table .= "</tr>";
}
    $table .= "</table>";
    echo $table;
}
$conn->close;


?>
    </table>

</body>
</html>
