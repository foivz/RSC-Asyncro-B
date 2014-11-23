<div class="container">
    <form class="form-horizontal" method="post" action="../app/controller/fridge.php">
        <fieldset>

            <!-- Form Name -->
            <legend>Add fridge</legend>
            <a name="id" value="<?php echo $id_institucije;?>"></a>
            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="capacity">Max capacity</label>
                <div class="col-md-4">
                    <input id="capacity" name="capacity" type="text" placeholder="" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="1">A+</label>
                <div class="col-md-4">
                    <input id="1" name="1" type="text" placeholder="" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="2">A-</label>
                <div class="col-md-4">
                    <input id="2" name="2" type="text" placeholder="" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="3">B+</label>
                <div class="col-md-4">
                    <input id="3" name="3" type="text" placeholder="" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="4">B-</label>
                <div class="col-md-4">
                    <input id="4" name="4" type="text" placeholder="" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="5">AB+</label>
                <div class="col-md-4">
                    <input id="5" name="5" type="text" placeholder="" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="6">AB-</label>
                <div class="col-md-4">
                    <input id="6" name="6" type="text" placeholder="" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="7">0+</label>
                <div class="col-md-4">
                    <input id="7" name="7" type="text" placeholder="" class="form-control input-md">

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="8">0-</label>
                <div class="col-md-4">
                    <input id="8" name="8" type="text" placeholder="" class="form-control input-md">

                </div>
            </div>
            <div class="form-group">
                <label class="col-md-4 control-label" for="submit"></label>
                <div class="col-md-4">
                    <button id="submit" name="id" value="<?php echo $id_institucije;?>" class="form-control input-md"">Create</button>

                </div>
            </div>

        </fieldset>
    </form>
</div>