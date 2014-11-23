<div class="header" id="home">
    <div class="container">
        <div class="logo">
            <h1><a href="index.html">Institution panel</a></h1>
        </div>
        <span class="menu"> </span>
        <div class="cleare"> </div>
        <script>
            $( "span.menu" ).click(function() {
                $( "ul.navig" ).slideToggle( "slow", function() {
                    // Animation complete.
                });
            });
        </script>
        <div class="navigation">
            <ul class="navig">
                <li><a href="/institution.php?id=<?php echo $id_institucije; ?>" >Edit institution</a></li>
                <li><a href="/add_fridge.php?id=<?php echo $id_institucije; ?>">Add fridge</a></li>
            </ul>

        </div>
        <div class="clearfix"> </div>
    </div>
</div>