<!DOCTYPE html>
<html>
<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);
include "app/Database.php";
$db = new Database();

$users = $db->query("SELECT id_user, username, picture, name, email, password FROM users WHERE id_user=?", array($id_institucije));


include "header.php";
include "headerAdmin.php";
?>
<body>
<div class="container">

    <form class="form-horizontal" method="post" action="../api/update_user.php">

        <button type="button" class="btn btn-primary">List all</button>

        <fieldset>

            <!-- Form Name -->
            <legend>New institution</legend>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="Username">Username</label>
                <div class="col-md-4">
                    <input id="Username" name="username" readonly type="text" placeholder="Institutions username" value="<?php echo $users['username'];?>" class="form-control input-md" required="">

                </div>
            </div>

            <!-- Password input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="Password">Password Input</label>
                <div class="col-md-4">
                    <input id="Password" name="password" type="password" placeholder="*********" value="<?php echo $users['password'];?>" class="form-control input-md" required="">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="email">Email</label>
                <div class="col-md-4">
                    <input id="email" name="email" type="text" placeholder="mail@example.com" value="<?php echo $users['email'];?>" class="form-control input-md" required="">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="name">Institutions name</label>
                <div class="col-md-4">
                    <input id="name" name="name" type="text" placeholder="Institutions name" value="<?php echo $users['name'];?>" class="form-control input-md" required="">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="picture">Picture URL</label>
                <div class="col-md-4">
                    <input id="picture" name="picture" type="text" placeholder="" value="<?php echo $users['picture'];?>" class="form-control input-md" required="">

                </div>
            </div>

            <div class="form-group">
                <label class="col-md-4 control-label" for="submit"></label>
                <div class="col-md-4">
                    <button id="submit" name="submit" class="form-control input-md"">Submit</button>

                </div>
            </div>
        </fieldset>
    </form>

</div>


</body>
</html>