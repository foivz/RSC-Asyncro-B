<div class="header" id="home">
    <div class="container">
        <div class="logo">
            <h1><a href="index.html">Admin panel</a></h1>
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
                <li><a href="/admin_list.php" >All Institutions</a></li>
                <li><a href="/admin_create.php">Add new</a></li>
            </ul>

        </div>
        <div class="clearfix"> </div>
    </div>
</div>