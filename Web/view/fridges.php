<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);
include "app/Database.php";
$db = new Database();
echo $id_institucije . "<br>";
$fridges = $db->query("SELECT * from fridge where institution=?", array($id_institucije), false, false);

?>

<div class="container">
    <h1>Fridges</h1>
    <?php if($fridges):?>
    <?php for($i=0;$i<sizeof($fridges);$i++):?>

    <form class="form-horizontal">
        <fieldset>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="capacity">Fridge <?php echo $i+1; ?> capacity</label>
                <div class="col-md-4">
                    <input id="capacity" name="capacity" value="<?php echo $fridges[$i]['capacity'] ?>" type="text" placeholder="" class="form-control input-md">

                </div>
            </div>


        </fieldset>
    </form>
    <?php endfor;?>
    <?php endif;?>
</div>