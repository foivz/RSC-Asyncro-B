<?php
/**
 * Created by PhpStorm.
 * User: Marko
 * Date: 22.11.2014.
 * Time: 23:44
 */
include "../app/Database.php";
$db = new Database();

if(isset($_POST['email'])) {
    $to = $_POST['email'];
    $username = $_POST['username'];
}
else
    return;

$users = $db->query("SELECT password FROM users WHERE username = ? and email = ?", array($username, $to) );

if($users) {
    $url = 'http://arka.foi.hr/~maleric/rsc/forgot.php';
    $data = array('mail' => $to, 'message' => 'Hello,' . $username . ',your password is: ' . $users['password'] . '. Take care!', 'subject' => 'Password recover');

// use key 'http' even if you send the request to https://...
    $options = array(
        'http' => array(
            'header' => "Content-type: application/x-www-form-urlencoded\r\n",
            'method' => 'POST',
            'content' => http_build_query($data),
        ),
    );
    $context = stream_context_create($options);
    $result = file_get_contents($url, false, $context);
    if(isset($_POST['submit']))
        header('location: ../index.php');

}else{
    if(isset($_POST['submit']))
        header('location: ../forgot_password.php');
    else echo 0;

}

/*
$to = $_POST['mail'];
$from = "maleric@foi.hr";
$message = $_POST['message'];
$subject = $_POST['subject'];
if (isset($to))
    mail($to, $subject, $message, "From: ".$from);*/