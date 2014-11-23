<!DOCTYPE html>
<html>
<?php
 include "header.php";
 include "headerAdmin.php";
?>
    <body>
    <div class="container">
        <form class="form-horizontal" method="post" action="../api/register.php">
            <fieldset>

                <!-- Form Name -->
                <legend>New institution</legend>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="Username">Username</label>
                    <div class="col-md-4">
                        <input id="Username" name="username" type="text" placeholder="Institutions username" class="form-control input-md" required="">

                    </div>
                </div>

                <!-- Password input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="Password">Password Input</label>
                    <div class="col-md-4">
                        <input id="Password" name="password" type="password" placeholder="*********" class="form-control input-md" required="">

                    </div>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="email">Email</label>
                    <div class="col-md-4">
                        <input id="email" name="email" type="text" placeholder="mail@example.com" class="form-control input-md" required="">

                    </div>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="name">Institutions name</label>
                    <div class="col-md-4">
                        <input id="name" name="name" type="text" placeholder="Institutions name" class="form-control input-md" required="">

                    </div>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-4 control-label" for="picture">Picture URL</label>
                    <div class="col-md-4">
                        <input id="picture" name="picture" type="text" placeholder="" class="form-control input-md" required="">

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