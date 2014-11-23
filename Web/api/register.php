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
    $surname = " ";
    $type = 1;
    if(isset($_POST['surname']))
        $surname = $_POST['surname'];
    if(isset($_POST['submit']))
        $type=2;

    $user = $db->query("INSERT INTO users SET username=?, password=?, type = ?, active = 1, email = ?, name = ?, blood_type=?, surname = ? ", array($_POST['username'],$_POST['password'],$type, $_POST['email'],$_POST['name'],"1",$surname));
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
else if(isset($_POST['submit']))
    header('location: ../error.php');
else
    echo "0";
