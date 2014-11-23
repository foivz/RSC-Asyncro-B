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

}


