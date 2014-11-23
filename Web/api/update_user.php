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
    $surname="";
    if(isset($_POST['surname']))
        $surname=$_POST['surname'];
    $user = $db->query("UPDATE users SET password=?, email = ?, name = ?, surname = ? WHERE username = ? ", array($_POST['password'],$_POST['email'],$_POST['name'],$surname, $_POST['username']));

    if(isset($_POST['submit']))
        if($user)
            header('location: ../admin_list.php');
        else
            header('location: ../error.php');

    if($user)
        echo 1;
    else
        echo 0;

}
else
    echo "0";
