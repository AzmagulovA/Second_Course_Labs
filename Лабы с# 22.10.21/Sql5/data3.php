<!doctype html>
<html lang="en">
<head>
<title>color </title>
<style>
input {color: #CCCCC0; background: #141414;}
html, body{
	height:100%
}

body{
	
	width: 100%;
    height: 100%;
}
input[ name ="sqlz"] {
font-size: 18px;
height: 150px;
width: 250px;
 transform: translateY(250px);
}



  </style>
</head>
<?php


echo"<body bgcolor='#1A1A1A' > ";
?>
<meta charset="UTF-8">
<meta name="viewport"
content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
<meta http-equiv="X-UA-Compatible" content="ie=edge">
<title>Document</title>
</head>
<body>
<form action="sql5.php" >
   <button>Назад</button>
  </form>
<form method="POST">
 
 <input type="text" name="table" placeholder="Имя" />  <input type="text" name="number" placeholder="Количество кортежей" /> 
<input type="submit"  value="Добавить"/> 
 <p> 
 

<?php




header('Content-Type: text/html; charset=UTF-8');
error_reporting(E_ALL);




$servername="localhost";
$username="root";
$password="";
$dbname="lab4";


$mysqli= new mysqli($servername,$username,$password,$dbname);



if($_POST['table'])
            {
                //$table = $_POST['table'];
                file_put_contents('table.txt', $_POST['table']);
                //$number = $_POST['number'];
                file_put_contents('number.txt', $_POST['number']);
                echo '<meta http-equiv = "Refresh" CONTENT="0; URL = /crtT.php">';
            }

;





?>





?>
</table>

</body>
</html>
