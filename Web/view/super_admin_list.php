<!DOCTYPE html>
<html>
<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

include "header.php";
include "headerAdmin.php";
?>
<body>
<div class="container">
    <table class="table">
        <thead>
        <tr>
            <th>Name</th>
            <th>Username</th>
            <th>Adress</th>
            <th>Blood Capacity</th>
            <th>Used Capacity</th>
            <th>Operation</th>
        </tr>
        </thead>
        <tbody>

        <?php

        include "app/Database.php";
        $db = new Database();

        $institution = $db->query("SELECT id_user, username, adress, picture, id_fridge, name, capacity FROM fridge f"
            . " RIGHT JOIN users u ON u.id_user=f.institution"
            . " LEFT JOIN adress a ON a.users_id_user = u.id_user WHERE type=2");

        for ($i = 0; $i < sizeof($institution);$i++) {
            $stored = $db->query("SELECT SUM(stored) from fridge_has_blood f WHERE f.fridge_id_fridge = ?", array($institution[$i]['id_fridge']));
            $institution[$i]['stored'] = $stored["SUM(stored)"];

            if(!$institution[$i]['stored'])$institution[$i]['stored']="N/A";
            if(!$institution[$i]['capacity'])$institution[$i]['capacity']="N/A";
            if(!$institution[$i]['adress'])$institution[$i]['adress']="N/A";

            echo "<tr>";
            echo "<td>".$institution[$i]['name']."</td>";
            echo "<td>".$institution[$i]['username']."</td>";
            echo "<td>".$institution[$i]['adress']."</td>";
            echo "<td>".$institution[$i]['capacity']."</td>";
            echo "<td>".$institution[$i]['stored']."</td>";
            echo "<td> <a class='btn btn-default' href='admin_edit.php?id=".$institution[$i]['id_user']."'>EDIT</a></td>";
            echo "</tr>";
        }


        ?>
        </tbody>
    </table>


</div>


</body>
</html>