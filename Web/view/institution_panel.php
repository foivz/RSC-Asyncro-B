<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);
include "app/Database.php";
$db = new Database();
//PANEL FOR INSTITUTION


$users = $db->query("SELECT id_user, username, picture, name, email, password  FROM users WHERE id_user=?", array($id_institucije));

?>
<div class="container">
    <form class="form-horizontal" method="post" action="../app/controller/institution_update.php">
        <fieldset>
            <!-- Form Name -->
            <legend>Edit information</legend>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="name">Institution name</label>
                <div class="col-md-4">
                    <input id="name" name="name" type="text" placeholder="" value="<?php echo $users['name'];?>" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="username">Username</label>
                <div class="col-md-4">
                    <input id="username" readonly name="username" type="text" placeholder="" value="<?php echo $users['username'];?>" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="password">Password</label>
                <div class="col-md-4">
                    <input id="password" name="password" type="password" placeholder="" value="<?php echo $users['password'];?>" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="email">E-mail</label>
                <div class="col-md-4">
                    <input id="email" name="email" type="text" placeholder="" value="<?php echo $users['email'];?>" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="picture">Picture URL</label>
                <div class="col-md-4">
                    <input id="picture" name="picture" type="text" placeholder="" value="<?php echo $users['picture'];?>" class="form-control input-md">

                </div>
            </div>


            <div class="form-group">
                <label class="col-md-4 control-label" for="submit"></label>
                <div class="col-md-4">
                    <button id="submit" name="submit" value= class="form-control input-md"">Update</button>

                </div>
            </div>
        </fieldset>
    </form>
</div>
