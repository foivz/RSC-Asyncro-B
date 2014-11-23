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


if (isset($_POST['username'])){

    $user = $db->query("UPDATE users SET password=?, email = ?, name = ?, surname = ? WHERE username = ? ", array($_POST['password'],$_POST['email'],$_POST['name'],$_POST['surname'], $_POST['username']));
    if($user)
        echo 1;
    else
        echo 0;

}
else
    echo "0";
