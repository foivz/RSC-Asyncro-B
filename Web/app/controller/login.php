<?php
/**
 * Created by PhpStorm.
 * User: Marko
 * Date: 22.11.2014.
 * Time: 20:10
 */

include "../Database.php";
$db = new Database();

if (isset($_POST['username']) && isset($_POST['password'])){
    $users = $db->query("SELECT id_user, username, type, email, name, surname FROM users WHERE username = ? and password = ?", array($_POST['username'], $_POST['password']));
    if(!$users)
        header('location: ../../login.html');
    else{
        if($users['type']==3) header('location: ../../admin_create.php');
        elseif($users['type']==2) header('location: ../../institution.php?id='.$users['id_user']);
        else
            header('location: ../../login.html');

    }
}
else
    header('location: ../../login.html');


