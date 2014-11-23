<?php

error_reporting(E_ALL);
ini_set('display_errors', 1);


include "../Database.php";
$db = new Database();


if (isset($_POST['capacity']) && isset($_POST['id'])) {
    var_dump($_POST);
    $capacity = $_POST['capacity'];
    $id=$_POST['id'];

    $fridge = $db->query("INSERT INTO fridge SET institution=?, capacity = ?", array($id, $capacity));


    if($fridge) {
        header('location: ../../add_fridge.php');

    }
    else
        header('location: ../../error.php');

}
else
    header('location: ../../error.php');