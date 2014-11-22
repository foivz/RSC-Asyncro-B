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


$institution = $db->query("SELECT username, picture, id_fridge, name, capacity FROM fridge f"
    ." RIGHT JOIN users u ON u.id_user=f.institution WHERE type=2");

for ($i=0;$i<sizeof($institution);$i++) {
    $stored = $db->query("SELECT SUM(stored) from fridge_has_blood f WHERE f.fridge_id_fridge = ?", array($institution[$i]['id_fridge']));
    $institution[$i]['stored'] = $stored["SUM(stored)"];
}


echo "<pre>";
echo json_encode($institution);
echo "</pre>";
