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
    $users = $db->query("SELECT username, password, active, email FROM users WHERE username = ?", array($_POST['username']));
    if($users["password"] == $_POST['password'])
        echo json_encode($users);
    else
        echo 0;

}
else
    echo "0";
