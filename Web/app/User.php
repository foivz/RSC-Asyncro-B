<?php
/**
 * Created by PhpStorm.
 * User: Marko
 * Date: 22.11.2014.
 * Time: 20:27
 */

class User {

    function __construct(){

    }
    public function getAll(){
        require "Database.php";
        $db = new Database();
        return $db->getData("users");
    }

} 