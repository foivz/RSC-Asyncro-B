<?php

class Database extends PDO{

    function __construct() {
        require 'config/database.php';
        parent::__construct(DB_TYPE.':host='.DB_HOST.';dbname='.DB_NAME, DB_USER, DB_PASS);

    }
    public function getData($table) {
        $sth= $this->prepare("SELECT * FROM ".$table);
        $sth->execute();
        $data=$sth->fetchAll(PDO::FETCH_ASSOC);
        return $data;

    }

    public function query($queryString, $param = NULL, $formatValue = true, $statistic=false) {
        if ($param != NULL) {
            foreach ($param as $value) {
                $limit = 1;
                $queryString = preg_replace("/\?/", "'" . $value . "'", $queryString, $limit);
            }
        }
        //echo $queryString;

        $sth = $this->prepare($queryString);
        $send = $sth->execute();
        //print_r($sth->errorInfo());
        //print_r (strpos($queryString, "SELECT"));


        if (strpos($queryString, "SELECT") !== false) {
            $data = $sth->fetchAll(PDO::FETCH_ASSOC);
            if (count($data) > 1)
                return $data;
            elseif (count($data) == 1 && $formatValue)
                return $data[0];
            else if(count($data) == 1) return $data;
            else
                return false;
        }
        elseif (strpos($queryString, "INSERT") !== false) {
            if ($send)
                return $this->lastInsertId();
            else
                return false;
        }
        elseif (strpos($queryString, "UPDATE") !== false) {
            if ($send)
                return true;
            else
                return false;
        }
        elseif (strpos($queryString, "DELETE") !== false) {
            if ($send)
                return true;
            else
                return false;
        } else
            return false;
    }


    public function insertArtices($user) {
        $sth = $this->prepare("INSERT INTO articles VALUES (:ean, :description, :capacity, :unit)");
        $send=$sth->execute(array(
            ':ean'=>$user->ean,
            ':description' => $user->description,
            ':capacity' => $user->capacity,
            ':unit' => $user->unit
        ));
    }
    public function insertCategory($user) {
        $sth = $this->prepare("INSERT INTO category VALUES (:id, :name, :description, :pid)");
        $send=$sth->execute(array(
            ':id'=>$table,
            ':name' => $user->name,
            ':description' => $user->description,
            ':pid' => $user->pid
        ));
    }
    public function insertLocation($user) {
        $sth = $this->prepare("INSERT INTO locations SET "
            . "'id=DEFAULT"
            . ",name='".$user->name
            . "',adress= '".$user->adress
            . "',location='".$user->location."'");
        $send=$sth->execute();
        if(!$send) return false;
        else return true;
    }
    public function insertScans($user) {
        $sth = $this->prepare("INSERT INTO scans VALUES (:id, :location, :locations_id, :currentTime, :costumers_id, :articles, :cost)");
        $send=$sth->execute(array(
            ':id'=>"DEFAULT",
            ':location' => $user->location,
            ':locations_id' => $user->locations_id,
            ':currentTime' => $user->currentTime,
            ':costumers_id' => $user->costumers_id,
            ':articles' => $user->articles,
            ':cost' => $user->cost,
        ));
    }
    public function insertCostumers($user) {
        $sth = $this->prepare("INSERT INTO costumers VALUES (:id, :deviceId, :deviceModel)");
        $send=$sth->execute(array(
            ':id'=>"DEFAULT",
            ':deviceId' => $user->deviceId,
            ':deviceModel' => $user->deviceModel,
        ));
    }


    public function getLocation($location) {
        $sth= $this->prepare("SELECT id FROM locations WHERE "
            . "location = ".$location.")");
        $sth->execute();
        $data=$sth->fetch();
        return $data;

    }
    public function getCostumer($deviceId) {
        $sth= $this->prepare("SELECT id FROM costumers WHERE "
            . "deviceId = :deviceId");
        $sth->execute(array(':deviceId' => $deviceId ));
        $data=$sth->fetch();
        return $data;

    }
    public function getTeams() {
        $sth= $this->prepare("SELECT * FROM timovi");
        $sth->execute();
        $data=$sth->fetchAll(PDO::FETCH_ASSOC);
        return $data;

    }
}


