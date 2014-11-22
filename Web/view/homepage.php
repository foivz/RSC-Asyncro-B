
<body>
<!--- Header Starts Here --->
<div class="header" id="home">
    <div class="container">
        <div class="logo">
            <h1><a href="index.html">Blood Donations</a></h1>
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
                <li><a class="active" href="#home" class="scroll">HOME</a></li>
                <li><a href="#about" class="scroll">ABOUT</a></li>
                <li><a href="#services" class="scroll">SERVICES</a></li>
                <li><a href="#project" class="scroll">PROJECTS</a></li>
                <li><a href="#contact" class="scroll">CONTACT</a></li>
                <li><a href="/registration.html" class="scroll">REGISTRATION</a></li>
                <li><a href="login.html" >LOGIN</a></li>
            </ul>

        </div>
        <div class="clearfix"> </div>
    </div>
</div>
<!--- Header Ends Here --->
<!-- Banner Starts Here -->

<div class="banner">
    <div class="slider">
        <section class="slider">
            <div class="flexslider">
                <ul class="slides">
                    <li>
                        <h2>IPSUM DOLOR SIT AMET LAT</h2>
                        <h5>Allquam tincidunt mauris cu risus</h5>
                    </li>
                    <li>
                        <h2>IPSUM DOLOR SIT AMET LAT</h2>
                        <h5>Allquam tincidunt mauris cu risus</h5>
                    </li>
                    <li>
                        <h2>IPSUM DOLOR SIT AMET LAT</h2>
                        <h5>Allquam tincidunt mauris cu risus</h5>
                    </li>
                    <li>
                        <h2>IPSUM DOLOR SIT AMET LAT</h2>
                        <h5>Allquam tincidunt mauris cu risus</h5>
                    </li>
                </ul>
            </div>
        </section>
        <script>window.jQuery || document.write('<script src="view/rss/js/libs/jquery-1.7.min.js">\x3C/script>')</script>
        <!--FlexSlider-->
        <script defer src="view/rss/js/jquery.flexslider.js"></script>
        <script type="text/javascript">
            $(function(){
                SyntaxHighlighter.all();
            });
            $(window).load(function(){
                $('.flexslider').flexslider({
                    animation: "slide",
                    start: function(slider){
                        $('body').removeClass('loading');
                    }
                });
            });
        </script>
    </div>
</div>
<div class="about" id="about">
    <div class="container">
        <div class="about1 clock wow bounceIn">
            <div class="col-md-6 ">
                <div class="about-top">
                    <h2>MORBI IN SEM LOREM PLACERAT ORNARE PELLENTE</h2>
                    <h3>EUISMOD IN,PHARETRA ULTRICIES CRASCONSEQUAT VAVIMUS SUP SOMPURKOI VARSIT</h3>
                    <a href="#">MORE INFO</a>
                </div>
                <div class="clearfix"> </div>
            </div>
            <div class="col-md-6">
                <div class="about-bottom">
                    <a href="#"><p class="para1">Morbi interdum mollis sapien. Sed ac risus. Phasellus lacinia, magna a ullamcorper laoreet,lectus arcu pulvinar ricus lorem ipsum dolor</p></a>
                    <p class="para2">vitae facilisis libero dolor a purus. Sed vel lacus. Mauris nibh felis , adipiscing varius, adipiscing in,lacinia vel, tellus. Suspendisse ac urna. Etiam pellentesque mauris ut lectus.</p>
                    <p class="para3">Suspendisse mauris. Fusce accumsan mollis eros. Pellentesque a diam sit amet mi ullamcorper vehicula. integeralesuada.</p>
                </div>
            </div>
            <div class="clearfix"> </div>
        </div>
    </div>
</div>
<div class="content" id="services">
    <div class="container">
        <div class="content-1 clock wow bounceIn">
            <div class="col-md-4">
                <div class="content-grids">
                    <div class="content-left">
                        <span class="cnt1"> </span>
                    </div>
                    <div class="content-right">
                        <h3>CESTIBULUM AUCT</h3>
                        <P>Praesent dapibus, neque id cursus fauci-bus, tortor neque egestas augue,euin vulputate magna eros lipsum</P>
                        <a href="#">MORE</a>
                    </div>
                    <div class="clearfix"> </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="content-grids">
                    <div class="content-left">
                        <span class="cnt2"> </span>
                    </div>
                    <div class="content-right">
                        <h3>VETAE  FACILLIS</h3>
                        <P>Craesent dapibus, neque id cursus fauci-bus, tortor neque egestas augue,euin vulputate magna eros lipsum</P>
                        <a href="#">MORE</a>
                    </div>
                    <div class="clearfix"> </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="content-grids">
                    <div class="content-left">
                        <span class="cnt3"> </span>
                    </div>
                    <div class="content-right">
                        <h3>INTEGRE FUSCE</h3>
                        <P>Jraesent dapibus, neque id cursus fauci-bus, tortor neque egestas augue,euin vulputate magna eros lipsum</P>
                        <a href="#">MORE</a>
                    </div>
                    <div class="clearfix"> </div>
                </div>
            </div>
            <div class="clearfix"> </div>
        </div>
    </div>
</div>
<div class="project">
    <div class="container">
        <div class="project-1 clock wow bounceIn">
            <h3>MORBI IN SEM LOREM PLACERAT</h3>
            <P>EUISMOD IN PHARETRA ULTRICIES CRASCONSEQUAT VAVIMUS SUP</P>
            <form>
                <input type="text" size="30px"  value="cresent sbsum..." onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'cresent sbsum...';}">

                <input type="submit" value="EGESTE">
            </form>
        </div>
    </div>
</div>

<!--Responsive-tabs-Starts-Here-->
<div class="responsive-tabs" id="project">
    <div class="container">
        <div class="tabs-box clock wow bounceIn">
            <ul class="tabs-menu">
                <li><a href="#tab1"><img src="view/rss/images/f.png" alt="">SED EGEST ASTEET</a></li>
                <li><a href="#tab2"><img src="view/rss/images/d.png" alt="">MORBI INTERDUM</a></li>
                <li><a href="#tab3"><img src="view/rss/images/u.png" alt="">MORBI INTERDUM</a></li>
            </ul>
            <div class="clearfix"> </div>
            <div class="tab-grids">
                <div id="tab1" class="tab-grid">
                    <div class="col-md-6 line1">
                        <img src="view/rss/images/hny.jpg" alt="">
                        <p>Sed egestas, ante et vulputate volutpat, eros pede semper est, vitae luctus metus libero eu augue. Morbi purus libero, faucibus adipiscing, commodo quis Gravida id, est. Sed lectus. Praesent elementum hendrerit tortor. Sed semper lorem at felis lorem ipsum dolor.</p>
                    </div>
                    <div class="col-md-6 line2">
                        <img src="view/rss/images/hny1.jpg" alt="">
                        <p>Lorem egestas, ante et vulputate volutpat, eros pede semper est, vitae luctus metus libero eu augue. Morbi purus libero, faucibus adipiscing, commodo quis Gravida id, est. Sed lectus. Praesent elementum hendrerit tortor. Sed semper at felis lorem ipsum dolor.</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div id="tab2" class="tab-grid">
                    <div class="col-md-6 line1">
                        <img src="view/rss/images/cake.jpg" alt="">
                        <p>Sed egestas, ante et vulputate volutpat, eros pede semper est, vitae luctus metus libero eu augue. Morbi purus libero, faucibus adipiscing, commodo quis Gravida id, est. Sed lectus. Praesent elementum hendrerit tortor. Sed semper lorem at felis lorem ipsum dolor.</p>
                    </div>
                    <div class="col-md-6 line2">
                        <img src="view/rss/images/sandwich.jpg" alt="">
                        <p>Lorem egestas, ante et vulputate volutpat, eros pede semper est, vitae luctus metus libero eu augue. Morbi purus libero, faucibus adipiscing, commodo quis Gravida id, est. Sed lectus. Praesent elementum hendrerit tortor. Sed semper at felis lorem ipsum dolor.</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div id="tab3" class="tab-grid">
                    <div class="col-md-6 line1">
                        <img src="view/rss/images/melt.jpg" alt="">
                        <p>Sed egestas, ante et vulputate volutpat, eros pede semper est, vitae luctus metus libero eu augue. Morbi purus libero, faucibus adipiscing, commodo quis Gravida id, est. Sed lectus. Praesent elementum hendrerit tortor. Sed semper lorem at felis lorem ipsum dolor.</p>
                    </div>
                    <div class="col-md-6 line2">
                        <img src="view/rss/images/beef.jpg" alt="">
                        <p>Lorem egestas, ante et vulputate volutpat, eros pede semper est, vitae luctus metus libero eu augue. Morbi purus libero, faucibus adipiscing, commodo quis Gravida id, est. Sed lectus. Praesent elementum hendrerit tortor. Sed semper at felis lorem ipsum dolor.</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
            </div>
        </div>
    </div>
    <!--Script-->
    <script src="view/rss/js/jquery-1.11.0.min.js"></script>
    <script src="view/rss/js/myscript.js"> </script>
    `		<!--Script-->
</div>
<!--Responsive-tabs-ends-Here-->
<div class="contact" id="contact">
    <div class="container">
        <div class="contact-1 clock wow bounceIn">
            <div class="col-md-3 contact-top1">
                <h3>BLOG POSTS</h3>
                <div class="contact-grid">
                    <div class="contact-left">
                        <img src="view/rss/images/men-2.png" alt="">
                    </div>
                    <div class="contact-right">
                        <span>Aug/27/2013</span>
                        <h4>Cohn Doe</h4>
                        <p>Praesent dapibus, neque id cursus faucibus, tortor ...</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div class="contact-grid">
                    <div class="contact-left">
                        <img src="view/rss/images/wmn.png" alt="">
                    </div>
                    <div class="contact-right">
                        <span>Aug/27/2013</span>
                        <h4>Cohn Doe</h4>
                        <p>Praesent dapibus, neque id cursus faucibus, tortor ...</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div class="contact-grid">
                    <div class="contact-left">
                        <img src="view/rss/images/men-1.png" alt="">
                    </div>
                    <div class="contact-right">
                        <span>Aug/27/2013</span>
                        <h4>Cohn Doe</h4>
                        <p>Praesent dapibus, neque id cursus faucibus, tortor ...</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
            </div>
            <div class="col-md-3 contact-top2">
                <h3>TWITTER POSTS</h3>
                <div class="contact-grid1">
                    <div class="contact-left1">
                        <a href="#"><img src="view/rss/images/twitter.png" alt=""></a>
                    </div>
                    <div class="contact-right1">
                        <h4>@rafimit</h4>
                        <p>Morbi interdum mollis sapien sed ac risus. Phasellus lacinia</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div class="contact-grid1">
                    <div class="contact-left1">
                        <a href="#"><img src="view/rss/images/twitter.png" alt=""></a>
                    </div>
                    <div class="contact-right1">
                        <h4>@johndoe</h4>
                        <p>Morbi interdum mollis sapien sed ac risus. Phasellus lacinia</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div class="contact-grid1">
                    <div class="contact-left1">
                        <a href="#"><img src="view/rss/images/twitter.png" alt=""></a>
                    </div>
                    <div class="contact-right1">
                        <h4>@amanda</h4>
                        <p>Morbi interdum mollis sapien sed ac risus. Phasellus lacinia</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div class="contact-grid1">
                    <div class="contact-left1">
                        <a href="#"><img src="view/rss/images/twitter.png" alt=""></a>
                    </div>
                    <div class="contact-right1">
                        <h4>@peter</h4>
                        <p>Morbi interdum mollis sapien sed ac risus. Phasellus lacinia</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
            </div>
            <div class="col-md-6 contact-top3">
                <h3>QUICK CONTACT</h3>
                <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d30912.73175219394!2d79.98639619999999!3d14.4218904!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2sin!4v1410591500477" width="600" height="450" frameborder="0" style="border:0"> </iframe>
                <h4>Address</h4>
                <p>Building name, some street name, some city name, country</p>
                <a href="mailto:info@example.com">info@sitename.com  /  (000)  888 888 8888</a>
            </div>
            <div class="clearfix"> </div>
        </div>
    </div>
</div>