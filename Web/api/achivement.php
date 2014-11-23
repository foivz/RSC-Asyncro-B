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


$users = $db->query("SELECT id_user, name, username, picture FROM users WHERE type=1");
$achivements = array();
$j=0;
for ($i=0;$i<sizeof($users);$i++) {
    $stored = $db->query("SELECT COUNT(id_donations) from donation WHERE user = ?", array($users[$i]['id_user']));
    $users[$i]['donations'] = $stored["COUNT(id_donations)"];
    if($users[$i]['donations']) {
        //$achivements[$i] = array();
        $achivements[$j++] = $users[$i];
        }
}
echo json_encode($achivements);

