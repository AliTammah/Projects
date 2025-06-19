

<?php
$dsn = "mysql:host=localhost;dbname=phones";
$user='root';
$password= ''
;

try{
    $pdo = new PDO($dsn, $user, $password);
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    

    echo "You are coonected<br>";
}
catch(PDOException $e){

    echo "failed". $e->getMessage();
}



?>