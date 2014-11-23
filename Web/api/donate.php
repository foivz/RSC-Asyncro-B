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


if (isset($_POST['date']) && isset($_POST['username'])) {
    $user = $db->query("SELECT id_user FROM users where username = ? ", array($_POST['username']));
    $user_id=$user['id_user'];
    $institution = $db->query("SELECT id_user FROM users where type = 2 and username=?", array($_POST['institution']));
    if ($user && $institution) {
        $donation = $db->query("INSERT INTO donation SET date=?, user=?, institution = ? ", array($_POST['date'],$user_id, $institution['id_user']));

        if ($donation)
            echo 1;
        else
            echo 0;
    } else
        echo 0;

} else
    echo "0";
