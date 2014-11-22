<?php
/**
 * Created by PhpStorm.
 * User: Marko
 * Date: 22.11.2014.
 * Time: 20:10
 */

error_reporting(E_ALL);
ini_set('display_errors', 1);


include "../app/Database.php";
$db = new Database();


if (isset($_POST['username']) && isset($_POST['password'])){

    $user = $db->query("INSERT INTO users SET username=?, password=?, type = 1, active = 1, email = ?, name = ?, surname = ? ", array($_POST['username'],$_POST['password'],$_POST['email'],$_POST['name'],$_POST['surname']));
    if($user)
        echo 1;
    else
        echo 0;

}
else
    echo "0";
