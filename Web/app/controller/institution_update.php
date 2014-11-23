<?php

error_reporting(E_ALL);
ini_set('display_errors', 1);


include "../Database.php";
$db = new Database();


if (isset($_POST['username'])){
    $pass=$_POST['password'];
    $name = $_POST['name'];
    $email = $_POST['email'];
    $picture = $_POST['picture'];
    $blood=1;
    if(isset($_POST['blood_type']))
        $blood=$_POST['blood_type'];

    $user = $db->query("UPDATE users SET password=?, email = ?, name = ?, picture = ?, blood_type=? WHERE username = ? ", array($pass, $email, $name, $picture, $blood, $_POST['username']));
    if($user) {
        $user = $db->query("SELECT id_user FROM users WHERE username = ?", array($_POST['username']));
        header('location: ../../institution.php?id=' . $user['id_user']);
    }
    else
        header('location: ../../error.php');

}
else
    echo "0";