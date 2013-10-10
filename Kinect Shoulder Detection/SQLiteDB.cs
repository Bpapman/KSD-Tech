



<!DOCTYPE html>
<html>
<head>
 <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" >
 <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" >
 
 <meta name="ROBOTS" content="NOARCHIVE">
 
 <link rel="icon" type="image/vnd.microsoft.icon" href="https://ssl.gstatic.com/codesite/ph/images/phosting.ico">
 
 
 <script type="text/javascript">
 
 
 
 
 var codesite_token = "NhV3P9Nj0TmtL8O6LnXLpg5N3So:1381443204623";
 
 
 var CS_env = {"projectName":"kinect-shoulder","projectHomeUrl":"/p/kinect-shoulder","assetVersionPath":"https://ssl.gstatic.com/codesite/ph/9670661675484913303","loggedInUserEmail":"bpapman@gmail.com","relativeBaseUrl":"","token":"NhV3P9Nj0TmtL8O6LnXLpg5N3So:1381443204623","profileUrl":"/u/bpapman/","domainName":null,"assetHostPath":"https://ssl.gstatic.com/codesite/ph"};
 var _gaq = _gaq || [];
 _gaq.push(
 ['siteTracker._setAccount', 'UA-18071-1'],
 ['siteTracker._trackPageview']);
 
 (function() {
 var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
 ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
 (document.getElementsByTagName('head')[0] || document.getElementsByTagName('body')[0]).appendChild(ga);
 })();
 
 </script>
 
 
 <title>SQLiteDB.cs - 
 kinect-shoulder -
 
 
 Temporary usage for code sharing until real repo is up - Google Project Hosting
 </title>
 <link type="text/css" rel="stylesheet" href="https://ssl.gstatic.com/codesite/ph/9670661675484913303/css/core.css">
 
 <link type="text/css" rel="stylesheet" href="https://ssl.gstatic.com/codesite/ph/9670661675484913303/css/ph_detail.css" >
 
 
 <link type="text/css" rel="stylesheet" href="https://ssl.gstatic.com/codesite/ph/9670661675484913303/css/d_sb.css" >
 
 
 
<!--[if IE]>
 <link type="text/css" rel="stylesheet" href="https://ssl.gstatic.com/codesite/ph/9670661675484913303/css/d_ie.css" >
<![endif]-->
 <style type="text/css">
 .menuIcon.off { background: no-repeat url(https://ssl.gstatic.com/codesite/ph/images/dropdown_sprite.gif) 0 -42px }
 .menuIcon.on { background: no-repeat url(https://ssl.gstatic.com/codesite/ph/images/dropdown_sprite.gif) 0 -28px }
 .menuIcon.down { background: no-repeat url(https://ssl.gstatic.com/codesite/ph/images/dropdown_sprite.gif) 0 0; }
 
 
 
  tr.inline_comment {
 background: #fff;
 vertical-align: top;
 }
 div.draft, div.published {
 padding: .3em;
 border: 1px solid #999; 
 margin-bottom: .1em;
 font-family: arial, sans-serif;
 max-width: 60em;
 }
 div.draft {
 background: #ffa;
 } 
 div.published {
 background: #e5ecf9;
 }
 div.published .body, div.draft .body {
 padding: .5em .1em .1em .1em;
 max-width: 60em;
 white-space: pre-wrap;
 white-space: -moz-pre-wrap;
 white-space: -pre-wrap;
 white-space: -o-pre-wrap;
 word-wrap: break-word;
 font-size: 1em;
 }
 div.draft .actions {
 margin-left: 1em;
 font-size: 90%;
 }
 div.draft form {
 padding: .5em .5em .5em 0;
 }
 div.draft textarea, div.published textarea {
 width: 95%;
 height: 10em;
 font-family: arial, sans-serif;
 margin-bottom: .5em;
 }

 
 .nocursor, .nocursor td, .cursor_hidden, .cursor_hidden td {
 background-color: white;
 height: 2px;
 }
 .cursor, .cursor td {
 background-color: darkblue;
 height: 2px;
 display: '';
 }
 
 
.list {
 border: 1px solid white;
 border-bottom: 0;
}

 
 </style>
</head>
<body class="t4">
<script type="text/javascript">
 window.___gcfg = {lang: 'en'};
 (function() 
 {var po = document.createElement("script");
 po.type = "text/javascript"; po.async = true;po.src = "https://apis.google.com/js/plusone.js";
 var s = document.getElementsByTagName("script")[0];
 s.parentNode.insertBefore(po, s);
 })();
</script>
<div class="headbg">

 <div id="gaia">
 

 <span>
 
 
 
 <a href="#" id="multilogin-dropdown" onclick="return false;"
 ><u><b>bpapman@gmail.com</b></u> <small>&#9660;</small></a>
 
 
 | <a href="/u/bpapman/" id="projects-dropdown" onclick="return false;"
 ><u>My favorites</u> <small>&#9660;</small></a>
 | <a href="/u/bpapman/" onclick="_CS_click('/gb/ph/profile');"
 title="Profile, Updates, and Settings"
 ><u>Profile</u></a>
 | <a href="https://www.google.com/accounts/Logout?continue=https%3A%2F%2Fcode.google.com%2Fp%2Fkinect-shoulder%2Fsource%2Fbrowse%2FSQLiteDB.cs" 
 onclick="_CS_click('/gb/ph/signout');"
 ><u>Sign out</u></a>
 
 </span>

 </div>

 <div class="gbh" style="left: 0pt;"></div>
 <div class="gbh" style="right: 0pt;"></div>
 
 
 <div style="height: 1px"></div>
<!--[if lte IE 7]>
<div style="text-align:center;">
Your version of Internet Explorer is not supported. Try a browser that
contributes to open source, such as <a href="http://www.firefox.com">Firefox</a>,
<a href="http://www.google.com/chrome">Google Chrome</a>, or
<a href="http://code.google.com/chrome/chromeframe/">Google Chrome Frame</a>.
</div>
<![endif]-->



 <table style="padding:0px; margin: 0px 0px 10px 0px; width:100%" cellpadding="0" cellspacing="0"
 itemscope itemtype="http://schema.org/CreativeWork">
 <tr style="height: 58px;">
 
 
 
 <td id="plogo">
 <link itemprop="url" href="/p/kinect-shoulder">
 <a href="/p/kinect-shoulder/">
 
 <img src="https://ssl.gstatic.com/codesite/ph/images/defaultlogo.png" alt="Logo" itemprop="image">
 
 </a>
 </td>
 
 <td style="padding-left: 0.5em">
 
 <div id="pname">
 <a href="/p/kinect-shoulder/"><span itemprop="name">kinect-shoulder</span></a>
 </div>
 
 <div id="psum">
 <a id="project_summary_link"
 href="/p/kinect-shoulder/"><span itemprop="description">Temporary usage for code sharing until real repo is up</span></a>
 
 </div>
 
 
 </td>
 <td style="white-space:nowrap;text-align:right; vertical-align:bottom;">
 
 <form action="/hosting/search">
 <input size="30" name="q" value="" type="text">
 
 <input type="submit" name="projectsearch" value="Search projects" >
 </form>
 
 </tr>
 </table>

</div>

 
<div id="mt" class="gtb"> 
 <a href="/p/kinect-shoulder/" class="tab ">Project&nbsp;Home</a>
 
 
 
 
 
 
 <a href="/p/kinect-shoulder/w/list" class="tab ">Wiki</a>
 
 
 
 
 
 <a href="/p/kinect-shoulder/issues/list"
 class="tab ">Issues</a>
 
 
 
 
 
 <a href="/p/kinect-shoulder/source/checkout"
 class="tab active">Source</a>
 
 
 
 
 
 <a href="/p/kinect-shoulder/admin"
 class="tab inactive">Administer</a>
 
 
 
 
 <div class=gtbc></div>
</div>
<table cellspacing="0" cellpadding="0" width="100%" align="center" border="0" class="st">
 <tr>
 
 
 
 
 
 
 <td class="subt">
 <div class="st2">
 <div class="isf">
 
 


 <span class="inst1"><a href="/p/kinect-shoulder/source/checkout">Checkout</a></span> &nbsp;
 <span class="inst2"><a href="/p/kinect-shoulder/source/browse/">Browse</a></span> &nbsp;
 <span class="inst3"><a href="/p/kinect-shoulder/source/list">Changes</a></span> &nbsp;
 
 
 
 
 
 <a href="/p/kinect-shoulder/issues/entry?show=review&former=sourcelist">Request code review</a>
 
 
 
 </form>
 <script type="text/javascript">
 
 function codesearchQuery(form) {
 var query = document.getElementById('q').value;
 if (query) { form.action += '%20' + query; }
 }
 </script>
 </div>
</div>

 </td>
 
 
 
 <td align="right" valign="top" class="bevel-right"></td>
 </tr>
</table>


<script type="text/javascript">
 var cancelBubble = false;
 function _go(url) { document.location = url; }
</script>
<div id="maincol"
 
>

 




<div class="expand">
<div id="colcontrol">
<style type="text/css">
 #file_flipper { white-space: nowrap; padding-right: 2em; }
 #file_flipper.hidden { display: none; }
 #file_flipper .pagelink { color: #0000CC; text-decoration: underline; }
 #file_flipper #visiblefiles { padding-left: 0.5em; padding-right: 0.5em; }
</style>
<table id="nav_and_rev" class="list"
 cellpadding="0" cellspacing="0" width="100%">
 <tr>
 
 <td nowrap="nowrap" class="src_crumbs src_nav" width="33%">
 <strong class="src_nav">Source path:&nbsp;</strong>
 <span id="crumb_root">
 
 <a href="/p/kinect-shoulder/source/browse/">svn</a>/&nbsp;</span>
 <span id="crumb_links" class="ifClosed">SQLiteDB.cs</span>
 
 


 </td>
 
 
 <td nowrap="nowrap" width="33%" align="center">
 <a href="/p/kinect-shoulder/source/browse/SQLiteDB.cs?edit=1"
 ><img src="https://ssl.gstatic.com/codesite/ph/images/pencil-y14.png"
 class="edit_icon">Edit file</a>
 </td>
 
 
 <td nowrap="nowrap" width="33%" align="right">
 <table cellpadding="0" cellspacing="0" style="font-size: 100%"><tr>
 
 
 <td class="flipper">
 <ul class="leftside">
 
 <li><a href="/p/kinect-shoulder/source/browse/SQLiteDB.cs?r=8" title="Previous">&lsaquo;r8</a></li>
 
 </ul>
 </td>
 
 <td class="flipper"><b>r11</b></td>
 
 </tr></table>
 </td> 
 </tr>
</table>

<div class="fc">
 
 
 
<style type="text/css">
.undermouse span {
 background-image: url(https://ssl.gstatic.com/codesite/ph/images/comments.gif); }
</style>
<table class="opened" id="review_comment_area"
onmouseout="gutterOut()"><tr>
<td id="nums">
<pre><table width="100%"><tr class="nocursor"><td></td></tr></table></pre>
<pre><table width="100%" id="nums_table_0"><tr id="gr_svn11_1"

 onmouseover="gutterOver(1)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',1);">&nbsp;</span
></td><td id="1"><a href="#1">1</a></td></tr
><tr id="gr_svn11_2"

 onmouseover="gutterOver(2)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',2);">&nbsp;</span
></td><td id="2"><a href="#2">2</a></td></tr
><tr id="gr_svn11_3"

 onmouseover="gutterOver(3)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',3);">&nbsp;</span
></td><td id="3"><a href="#3">3</a></td></tr
><tr id="gr_svn11_4"

 onmouseover="gutterOver(4)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',4);">&nbsp;</span
></td><td id="4"><a href="#4">4</a></td></tr
><tr id="gr_svn11_5"

 onmouseover="gutterOver(5)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',5);">&nbsp;</span
></td><td id="5"><a href="#5">5</a></td></tr
><tr id="gr_svn11_6"

 onmouseover="gutterOver(6)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',6);">&nbsp;</span
></td><td id="6"><a href="#6">6</a></td></tr
><tr id="gr_svn11_7"

 onmouseover="gutterOver(7)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',7);">&nbsp;</span
></td><td id="7"><a href="#7">7</a></td></tr
><tr id="gr_svn11_8"

 onmouseover="gutterOver(8)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',8);">&nbsp;</span
></td><td id="8"><a href="#8">8</a></td></tr
><tr id="gr_svn11_9"

 onmouseover="gutterOver(9)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',9);">&nbsp;</span
></td><td id="9"><a href="#9">9</a></td></tr
><tr id="gr_svn11_10"

 onmouseover="gutterOver(10)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',10);">&nbsp;</span
></td><td id="10"><a href="#10">10</a></td></tr
><tr id="gr_svn11_11"

 onmouseover="gutterOver(11)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',11);">&nbsp;</span
></td><td id="11"><a href="#11">11</a></td></tr
><tr id="gr_svn11_12"

 onmouseover="gutterOver(12)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',12);">&nbsp;</span
></td><td id="12"><a href="#12">12</a></td></tr
><tr id="gr_svn11_13"

 onmouseover="gutterOver(13)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',13);">&nbsp;</span
></td><td id="13"><a href="#13">13</a></td></tr
><tr id="gr_svn11_14"

 onmouseover="gutterOver(14)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',14);">&nbsp;</span
></td><td id="14"><a href="#14">14</a></td></tr
><tr id="gr_svn11_15"

 onmouseover="gutterOver(15)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',15);">&nbsp;</span
></td><td id="15"><a href="#15">15</a></td></tr
><tr id="gr_svn11_16"

 onmouseover="gutterOver(16)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',16);">&nbsp;</span
></td><td id="16"><a href="#16">16</a></td></tr
><tr id="gr_svn11_17"

 onmouseover="gutterOver(17)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',17);">&nbsp;</span
></td><td id="17"><a href="#17">17</a></td></tr
><tr id="gr_svn11_18"

 onmouseover="gutterOver(18)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',18);">&nbsp;</span
></td><td id="18"><a href="#18">18</a></td></tr
><tr id="gr_svn11_19"

 onmouseover="gutterOver(19)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',19);">&nbsp;</span
></td><td id="19"><a href="#19">19</a></td></tr
><tr id="gr_svn11_20"

 onmouseover="gutterOver(20)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',20);">&nbsp;</span
></td><td id="20"><a href="#20">20</a></td></tr
><tr id="gr_svn11_21"

 onmouseover="gutterOver(21)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',21);">&nbsp;</span
></td><td id="21"><a href="#21">21</a></td></tr
><tr id="gr_svn11_22"

 onmouseover="gutterOver(22)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',22);">&nbsp;</span
></td><td id="22"><a href="#22">22</a></td></tr
><tr id="gr_svn11_23"

 onmouseover="gutterOver(23)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',23);">&nbsp;</span
></td><td id="23"><a href="#23">23</a></td></tr
><tr id="gr_svn11_24"

 onmouseover="gutterOver(24)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',24);">&nbsp;</span
></td><td id="24"><a href="#24">24</a></td></tr
><tr id="gr_svn11_25"

 onmouseover="gutterOver(25)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',25);">&nbsp;</span
></td><td id="25"><a href="#25">25</a></td></tr
><tr id="gr_svn11_26"

 onmouseover="gutterOver(26)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',26);">&nbsp;</span
></td><td id="26"><a href="#26">26</a></td></tr
><tr id="gr_svn11_27"

 onmouseover="gutterOver(27)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',27);">&nbsp;</span
></td><td id="27"><a href="#27">27</a></td></tr
><tr id="gr_svn11_28"

 onmouseover="gutterOver(28)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',28);">&nbsp;</span
></td><td id="28"><a href="#28">28</a></td></tr
><tr id="gr_svn11_29"

 onmouseover="gutterOver(29)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',29);">&nbsp;</span
></td><td id="29"><a href="#29">29</a></td></tr
><tr id="gr_svn11_30"

 onmouseover="gutterOver(30)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',30);">&nbsp;</span
></td><td id="30"><a href="#30">30</a></td></tr
><tr id="gr_svn11_31"

 onmouseover="gutterOver(31)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',31);">&nbsp;</span
></td><td id="31"><a href="#31">31</a></td></tr
><tr id="gr_svn11_32"

 onmouseover="gutterOver(32)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',32);">&nbsp;</span
></td><td id="32"><a href="#32">32</a></td></tr
><tr id="gr_svn11_33"

 onmouseover="gutterOver(33)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',33);">&nbsp;</span
></td><td id="33"><a href="#33">33</a></td></tr
><tr id="gr_svn11_34"

 onmouseover="gutterOver(34)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',34);">&nbsp;</span
></td><td id="34"><a href="#34">34</a></td></tr
><tr id="gr_svn11_35"

 onmouseover="gutterOver(35)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',35);">&nbsp;</span
></td><td id="35"><a href="#35">35</a></td></tr
><tr id="gr_svn11_36"

 onmouseover="gutterOver(36)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',36);">&nbsp;</span
></td><td id="36"><a href="#36">36</a></td></tr
><tr id="gr_svn11_37"

 onmouseover="gutterOver(37)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',37);">&nbsp;</span
></td><td id="37"><a href="#37">37</a></td></tr
><tr id="gr_svn11_38"

 onmouseover="gutterOver(38)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',38);">&nbsp;</span
></td><td id="38"><a href="#38">38</a></td></tr
><tr id="gr_svn11_39"

 onmouseover="gutterOver(39)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',39);">&nbsp;</span
></td><td id="39"><a href="#39">39</a></td></tr
><tr id="gr_svn11_40"

 onmouseover="gutterOver(40)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',40);">&nbsp;</span
></td><td id="40"><a href="#40">40</a></td></tr
><tr id="gr_svn11_41"

 onmouseover="gutterOver(41)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',41);">&nbsp;</span
></td><td id="41"><a href="#41">41</a></td></tr
><tr id="gr_svn11_42"

 onmouseover="gutterOver(42)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',42);">&nbsp;</span
></td><td id="42"><a href="#42">42</a></td></tr
><tr id="gr_svn11_43"

 onmouseover="gutterOver(43)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',43);">&nbsp;</span
></td><td id="43"><a href="#43">43</a></td></tr
><tr id="gr_svn11_44"

 onmouseover="gutterOver(44)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',44);">&nbsp;</span
></td><td id="44"><a href="#44">44</a></td></tr
><tr id="gr_svn11_45"

 onmouseover="gutterOver(45)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',45);">&nbsp;</span
></td><td id="45"><a href="#45">45</a></td></tr
><tr id="gr_svn11_46"

 onmouseover="gutterOver(46)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',46);">&nbsp;</span
></td><td id="46"><a href="#46">46</a></td></tr
><tr id="gr_svn11_47"

 onmouseover="gutterOver(47)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',47);">&nbsp;</span
></td><td id="47"><a href="#47">47</a></td></tr
><tr id="gr_svn11_48"

 onmouseover="gutterOver(48)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',48);">&nbsp;</span
></td><td id="48"><a href="#48">48</a></td></tr
><tr id="gr_svn11_49"

 onmouseover="gutterOver(49)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',49);">&nbsp;</span
></td><td id="49"><a href="#49">49</a></td></tr
><tr id="gr_svn11_50"

 onmouseover="gutterOver(50)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',50);">&nbsp;</span
></td><td id="50"><a href="#50">50</a></td></tr
><tr id="gr_svn11_51"

 onmouseover="gutterOver(51)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',51);">&nbsp;</span
></td><td id="51"><a href="#51">51</a></td></tr
><tr id="gr_svn11_52"

 onmouseover="gutterOver(52)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',52);">&nbsp;</span
></td><td id="52"><a href="#52">52</a></td></tr
><tr id="gr_svn11_53"

 onmouseover="gutterOver(53)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',53);">&nbsp;</span
></td><td id="53"><a href="#53">53</a></td></tr
><tr id="gr_svn11_54"

 onmouseover="gutterOver(54)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',54);">&nbsp;</span
></td><td id="54"><a href="#54">54</a></td></tr
><tr id="gr_svn11_55"

 onmouseover="gutterOver(55)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',55);">&nbsp;</span
></td><td id="55"><a href="#55">55</a></td></tr
><tr id="gr_svn11_56"

 onmouseover="gutterOver(56)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',56);">&nbsp;</span
></td><td id="56"><a href="#56">56</a></td></tr
><tr id="gr_svn11_57"

 onmouseover="gutterOver(57)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',57);">&nbsp;</span
></td><td id="57"><a href="#57">57</a></td></tr
><tr id="gr_svn11_58"

 onmouseover="gutterOver(58)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',58);">&nbsp;</span
></td><td id="58"><a href="#58">58</a></td></tr
><tr id="gr_svn11_59"

 onmouseover="gutterOver(59)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',59);">&nbsp;</span
></td><td id="59"><a href="#59">59</a></td></tr
><tr id="gr_svn11_60"

 onmouseover="gutterOver(60)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',60);">&nbsp;</span
></td><td id="60"><a href="#60">60</a></td></tr
><tr id="gr_svn11_61"

 onmouseover="gutterOver(61)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',61);">&nbsp;</span
></td><td id="61"><a href="#61">61</a></td></tr
><tr id="gr_svn11_62"

 onmouseover="gutterOver(62)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',62);">&nbsp;</span
></td><td id="62"><a href="#62">62</a></td></tr
><tr id="gr_svn11_63"

 onmouseover="gutterOver(63)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',63);">&nbsp;</span
></td><td id="63"><a href="#63">63</a></td></tr
><tr id="gr_svn11_64"

 onmouseover="gutterOver(64)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',64);">&nbsp;</span
></td><td id="64"><a href="#64">64</a></td></tr
><tr id="gr_svn11_65"

 onmouseover="gutterOver(65)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',65);">&nbsp;</span
></td><td id="65"><a href="#65">65</a></td></tr
><tr id="gr_svn11_66"

 onmouseover="gutterOver(66)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',66);">&nbsp;</span
></td><td id="66"><a href="#66">66</a></td></tr
><tr id="gr_svn11_67"

 onmouseover="gutterOver(67)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',67);">&nbsp;</span
></td><td id="67"><a href="#67">67</a></td></tr
><tr id="gr_svn11_68"

 onmouseover="gutterOver(68)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',68);">&nbsp;</span
></td><td id="68"><a href="#68">68</a></td></tr
><tr id="gr_svn11_69"

 onmouseover="gutterOver(69)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',69);">&nbsp;</span
></td><td id="69"><a href="#69">69</a></td></tr
><tr id="gr_svn11_70"

 onmouseover="gutterOver(70)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',70);">&nbsp;</span
></td><td id="70"><a href="#70">70</a></td></tr
><tr id="gr_svn11_71"

 onmouseover="gutterOver(71)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',71);">&nbsp;</span
></td><td id="71"><a href="#71">71</a></td></tr
><tr id="gr_svn11_72"

 onmouseover="gutterOver(72)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',72);">&nbsp;</span
></td><td id="72"><a href="#72">72</a></td></tr
><tr id="gr_svn11_73"

 onmouseover="gutterOver(73)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',73);">&nbsp;</span
></td><td id="73"><a href="#73">73</a></td></tr
><tr id="gr_svn11_74"

 onmouseover="gutterOver(74)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',74);">&nbsp;</span
></td><td id="74"><a href="#74">74</a></td></tr
><tr id="gr_svn11_75"

 onmouseover="gutterOver(75)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',75);">&nbsp;</span
></td><td id="75"><a href="#75">75</a></td></tr
><tr id="gr_svn11_76"

 onmouseover="gutterOver(76)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',76);">&nbsp;</span
></td><td id="76"><a href="#76">76</a></td></tr
><tr id="gr_svn11_77"

 onmouseover="gutterOver(77)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',77);">&nbsp;</span
></td><td id="77"><a href="#77">77</a></td></tr
><tr id="gr_svn11_78"

 onmouseover="gutterOver(78)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',78);">&nbsp;</span
></td><td id="78"><a href="#78">78</a></td></tr
><tr id="gr_svn11_79"

 onmouseover="gutterOver(79)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',79);">&nbsp;</span
></td><td id="79"><a href="#79">79</a></td></tr
><tr id="gr_svn11_80"

 onmouseover="gutterOver(80)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',80);">&nbsp;</span
></td><td id="80"><a href="#80">80</a></td></tr
><tr id="gr_svn11_81"

 onmouseover="gutterOver(81)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',81);">&nbsp;</span
></td><td id="81"><a href="#81">81</a></td></tr
><tr id="gr_svn11_82"

 onmouseover="gutterOver(82)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',82);">&nbsp;</span
></td><td id="82"><a href="#82">82</a></td></tr
><tr id="gr_svn11_83"

 onmouseover="gutterOver(83)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',83);">&nbsp;</span
></td><td id="83"><a href="#83">83</a></td></tr
><tr id="gr_svn11_84"

 onmouseover="gutterOver(84)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',84);">&nbsp;</span
></td><td id="84"><a href="#84">84</a></td></tr
><tr id="gr_svn11_85"

 onmouseover="gutterOver(85)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',85);">&nbsp;</span
></td><td id="85"><a href="#85">85</a></td></tr
><tr id="gr_svn11_86"

 onmouseover="gutterOver(86)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',86);">&nbsp;</span
></td><td id="86"><a href="#86">86</a></td></tr
><tr id="gr_svn11_87"

 onmouseover="gutterOver(87)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',87);">&nbsp;</span
></td><td id="87"><a href="#87">87</a></td></tr
><tr id="gr_svn11_88"

 onmouseover="gutterOver(88)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',88);">&nbsp;</span
></td><td id="88"><a href="#88">88</a></td></tr
><tr id="gr_svn11_89"

 onmouseover="gutterOver(89)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',89);">&nbsp;</span
></td><td id="89"><a href="#89">89</a></td></tr
><tr id="gr_svn11_90"

 onmouseover="gutterOver(90)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',90);">&nbsp;</span
></td><td id="90"><a href="#90">90</a></td></tr
><tr id="gr_svn11_91"

 onmouseover="gutterOver(91)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',91);">&nbsp;</span
></td><td id="91"><a href="#91">91</a></td></tr
><tr id="gr_svn11_92"

 onmouseover="gutterOver(92)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',92);">&nbsp;</span
></td><td id="92"><a href="#92">92</a></td></tr
><tr id="gr_svn11_93"

 onmouseover="gutterOver(93)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',93);">&nbsp;</span
></td><td id="93"><a href="#93">93</a></td></tr
><tr id="gr_svn11_94"

 onmouseover="gutterOver(94)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',94);">&nbsp;</span
></td><td id="94"><a href="#94">94</a></td></tr
><tr id="gr_svn11_95"

 onmouseover="gutterOver(95)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',95);">&nbsp;</span
></td><td id="95"><a href="#95">95</a></td></tr
><tr id="gr_svn11_96"

 onmouseover="gutterOver(96)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',96);">&nbsp;</span
></td><td id="96"><a href="#96">96</a></td></tr
><tr id="gr_svn11_97"

 onmouseover="gutterOver(97)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',97);">&nbsp;</span
></td><td id="97"><a href="#97">97</a></td></tr
><tr id="gr_svn11_98"

 onmouseover="gutterOver(98)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',98);">&nbsp;</span
></td><td id="98"><a href="#98">98</a></td></tr
><tr id="gr_svn11_99"

 onmouseover="gutterOver(99)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',99);">&nbsp;</span
></td><td id="99"><a href="#99">99</a></td></tr
><tr id="gr_svn11_100"

 onmouseover="gutterOver(100)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',100);">&nbsp;</span
></td><td id="100"><a href="#100">100</a></td></tr
><tr id="gr_svn11_101"

 onmouseover="gutterOver(101)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',101);">&nbsp;</span
></td><td id="101"><a href="#101">101</a></td></tr
><tr id="gr_svn11_102"

 onmouseover="gutterOver(102)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',102);">&nbsp;</span
></td><td id="102"><a href="#102">102</a></td></tr
><tr id="gr_svn11_103"

 onmouseover="gutterOver(103)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',103);">&nbsp;</span
></td><td id="103"><a href="#103">103</a></td></tr
><tr id="gr_svn11_104"

 onmouseover="gutterOver(104)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',104);">&nbsp;</span
></td><td id="104"><a href="#104">104</a></td></tr
><tr id="gr_svn11_105"

 onmouseover="gutterOver(105)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',105);">&nbsp;</span
></td><td id="105"><a href="#105">105</a></td></tr
><tr id="gr_svn11_106"

 onmouseover="gutterOver(106)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',106);">&nbsp;</span
></td><td id="106"><a href="#106">106</a></td></tr
><tr id="gr_svn11_107"

 onmouseover="gutterOver(107)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',107);">&nbsp;</span
></td><td id="107"><a href="#107">107</a></td></tr
><tr id="gr_svn11_108"

 onmouseover="gutterOver(108)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',108);">&nbsp;</span
></td><td id="108"><a href="#108">108</a></td></tr
><tr id="gr_svn11_109"

 onmouseover="gutterOver(109)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',109);">&nbsp;</span
></td><td id="109"><a href="#109">109</a></td></tr
><tr id="gr_svn11_110"

 onmouseover="gutterOver(110)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',110);">&nbsp;</span
></td><td id="110"><a href="#110">110</a></td></tr
><tr id="gr_svn11_111"

 onmouseover="gutterOver(111)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',111);">&nbsp;</span
></td><td id="111"><a href="#111">111</a></td></tr
><tr id="gr_svn11_112"

 onmouseover="gutterOver(112)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',112);">&nbsp;</span
></td><td id="112"><a href="#112">112</a></td></tr
><tr id="gr_svn11_113"

 onmouseover="gutterOver(113)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',113);">&nbsp;</span
></td><td id="113"><a href="#113">113</a></td></tr
><tr id="gr_svn11_114"

 onmouseover="gutterOver(114)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',114);">&nbsp;</span
></td><td id="114"><a href="#114">114</a></td></tr
><tr id="gr_svn11_115"

 onmouseover="gutterOver(115)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',115);">&nbsp;</span
></td><td id="115"><a href="#115">115</a></td></tr
><tr id="gr_svn11_116"

 onmouseover="gutterOver(116)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',116);">&nbsp;</span
></td><td id="116"><a href="#116">116</a></td></tr
><tr id="gr_svn11_117"

 onmouseover="gutterOver(117)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',117);">&nbsp;</span
></td><td id="117"><a href="#117">117</a></td></tr
><tr id="gr_svn11_118"

 onmouseover="gutterOver(118)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',118);">&nbsp;</span
></td><td id="118"><a href="#118">118</a></td></tr
><tr id="gr_svn11_119"

 onmouseover="gutterOver(119)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',119);">&nbsp;</span
></td><td id="119"><a href="#119">119</a></td></tr
><tr id="gr_svn11_120"

 onmouseover="gutterOver(120)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',120);">&nbsp;</span
></td><td id="120"><a href="#120">120</a></td></tr
><tr id="gr_svn11_121"

 onmouseover="gutterOver(121)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',121);">&nbsp;</span
></td><td id="121"><a href="#121">121</a></td></tr
><tr id="gr_svn11_122"

 onmouseover="gutterOver(122)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',122);">&nbsp;</span
></td><td id="122"><a href="#122">122</a></td></tr
><tr id="gr_svn11_123"

 onmouseover="gutterOver(123)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',123);">&nbsp;</span
></td><td id="123"><a href="#123">123</a></td></tr
><tr id="gr_svn11_124"

 onmouseover="gutterOver(124)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',124);">&nbsp;</span
></td><td id="124"><a href="#124">124</a></td></tr
><tr id="gr_svn11_125"

 onmouseover="gutterOver(125)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',125);">&nbsp;</span
></td><td id="125"><a href="#125">125</a></td></tr
><tr id="gr_svn11_126"

 onmouseover="gutterOver(126)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',126);">&nbsp;</span
></td><td id="126"><a href="#126">126</a></td></tr
><tr id="gr_svn11_127"

 onmouseover="gutterOver(127)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',127);">&nbsp;</span
></td><td id="127"><a href="#127">127</a></td></tr
><tr id="gr_svn11_128"

 onmouseover="gutterOver(128)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',128);">&nbsp;</span
></td><td id="128"><a href="#128">128</a></td></tr
><tr id="gr_svn11_129"

 onmouseover="gutterOver(129)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',129);">&nbsp;</span
></td><td id="129"><a href="#129">129</a></td></tr
><tr id="gr_svn11_130"

 onmouseover="gutterOver(130)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',130);">&nbsp;</span
></td><td id="130"><a href="#130">130</a></td></tr
><tr id="gr_svn11_131"

 onmouseover="gutterOver(131)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',131);">&nbsp;</span
></td><td id="131"><a href="#131">131</a></td></tr
><tr id="gr_svn11_132"

 onmouseover="gutterOver(132)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',132);">&nbsp;</span
></td><td id="132"><a href="#132">132</a></td></tr
><tr id="gr_svn11_133"

 onmouseover="gutterOver(133)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',133);">&nbsp;</span
></td><td id="133"><a href="#133">133</a></td></tr
><tr id="gr_svn11_134"

 onmouseover="gutterOver(134)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',134);">&nbsp;</span
></td><td id="134"><a href="#134">134</a></td></tr
><tr id="gr_svn11_135"

 onmouseover="gutterOver(135)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',135);">&nbsp;</span
></td><td id="135"><a href="#135">135</a></td></tr
><tr id="gr_svn11_136"

 onmouseover="gutterOver(136)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',136);">&nbsp;</span
></td><td id="136"><a href="#136">136</a></td></tr
><tr id="gr_svn11_137"

 onmouseover="gutterOver(137)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',137);">&nbsp;</span
></td><td id="137"><a href="#137">137</a></td></tr
><tr id="gr_svn11_138"

 onmouseover="gutterOver(138)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',138);">&nbsp;</span
></td><td id="138"><a href="#138">138</a></td></tr
><tr id="gr_svn11_139"

 onmouseover="gutterOver(139)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',139);">&nbsp;</span
></td><td id="139"><a href="#139">139</a></td></tr
><tr id="gr_svn11_140"

 onmouseover="gutterOver(140)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',140);">&nbsp;</span
></td><td id="140"><a href="#140">140</a></td></tr
><tr id="gr_svn11_141"

 onmouseover="gutterOver(141)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',141);">&nbsp;</span
></td><td id="141"><a href="#141">141</a></td></tr
><tr id="gr_svn11_142"

 onmouseover="gutterOver(142)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',142);">&nbsp;</span
></td><td id="142"><a href="#142">142</a></td></tr
><tr id="gr_svn11_143"

 onmouseover="gutterOver(143)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',143);">&nbsp;</span
></td><td id="143"><a href="#143">143</a></td></tr
><tr id="gr_svn11_144"

 onmouseover="gutterOver(144)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',144);">&nbsp;</span
></td><td id="144"><a href="#144">144</a></td></tr
><tr id="gr_svn11_145"

 onmouseover="gutterOver(145)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',145);">&nbsp;</span
></td><td id="145"><a href="#145">145</a></td></tr
><tr id="gr_svn11_146"

 onmouseover="gutterOver(146)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',146);">&nbsp;</span
></td><td id="146"><a href="#146">146</a></td></tr
><tr id="gr_svn11_147"

 onmouseover="gutterOver(147)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',147);">&nbsp;</span
></td><td id="147"><a href="#147">147</a></td></tr
><tr id="gr_svn11_148"

 onmouseover="gutterOver(148)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',148);">&nbsp;</span
></td><td id="148"><a href="#148">148</a></td></tr
><tr id="gr_svn11_149"

 onmouseover="gutterOver(149)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',149);">&nbsp;</span
></td><td id="149"><a href="#149">149</a></td></tr
><tr id="gr_svn11_150"

 onmouseover="gutterOver(150)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',150);">&nbsp;</span
></td><td id="150"><a href="#150">150</a></td></tr
><tr id="gr_svn11_151"

 onmouseover="gutterOver(151)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',151);">&nbsp;</span
></td><td id="151"><a href="#151">151</a></td></tr
><tr id="gr_svn11_152"

 onmouseover="gutterOver(152)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',152);">&nbsp;</span
></td><td id="152"><a href="#152">152</a></td></tr
><tr id="gr_svn11_153"

 onmouseover="gutterOver(153)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',153);">&nbsp;</span
></td><td id="153"><a href="#153">153</a></td></tr
><tr id="gr_svn11_154"

 onmouseover="gutterOver(154)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',154);">&nbsp;</span
></td><td id="154"><a href="#154">154</a></td></tr
><tr id="gr_svn11_155"

 onmouseover="gutterOver(155)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',155);">&nbsp;</span
></td><td id="155"><a href="#155">155</a></td></tr
><tr id="gr_svn11_156"

 onmouseover="gutterOver(156)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',156);">&nbsp;</span
></td><td id="156"><a href="#156">156</a></td></tr
><tr id="gr_svn11_157"

 onmouseover="gutterOver(157)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',157);">&nbsp;</span
></td><td id="157"><a href="#157">157</a></td></tr
><tr id="gr_svn11_158"

 onmouseover="gutterOver(158)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',158);">&nbsp;</span
></td><td id="158"><a href="#158">158</a></td></tr
><tr id="gr_svn11_159"

 onmouseover="gutterOver(159)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',159);">&nbsp;</span
></td><td id="159"><a href="#159">159</a></td></tr
><tr id="gr_svn11_160"

 onmouseover="gutterOver(160)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',160);">&nbsp;</span
></td><td id="160"><a href="#160">160</a></td></tr
><tr id="gr_svn11_161"

 onmouseover="gutterOver(161)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',161);">&nbsp;</span
></td><td id="161"><a href="#161">161</a></td></tr
><tr id="gr_svn11_162"

 onmouseover="gutterOver(162)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',162);">&nbsp;</span
></td><td id="162"><a href="#162">162</a></td></tr
><tr id="gr_svn11_163"

 onmouseover="gutterOver(163)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',163);">&nbsp;</span
></td><td id="163"><a href="#163">163</a></td></tr
><tr id="gr_svn11_164"

 onmouseover="gutterOver(164)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',164);">&nbsp;</span
></td><td id="164"><a href="#164">164</a></td></tr
><tr id="gr_svn11_165"

 onmouseover="gutterOver(165)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',165);">&nbsp;</span
></td><td id="165"><a href="#165">165</a></td></tr
><tr id="gr_svn11_166"

 onmouseover="gutterOver(166)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',166);">&nbsp;</span
></td><td id="166"><a href="#166">166</a></td></tr
><tr id="gr_svn11_167"

 onmouseover="gutterOver(167)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',167);">&nbsp;</span
></td><td id="167"><a href="#167">167</a></td></tr
><tr id="gr_svn11_168"

 onmouseover="gutterOver(168)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',168);">&nbsp;</span
></td><td id="168"><a href="#168">168</a></td></tr
><tr id="gr_svn11_169"

 onmouseover="gutterOver(169)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',169);">&nbsp;</span
></td><td id="169"><a href="#169">169</a></td></tr
><tr id="gr_svn11_170"

 onmouseover="gutterOver(170)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',170);">&nbsp;</span
></td><td id="170"><a href="#170">170</a></td></tr
><tr id="gr_svn11_171"

 onmouseover="gutterOver(171)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',171);">&nbsp;</span
></td><td id="171"><a href="#171">171</a></td></tr
><tr id="gr_svn11_172"

 onmouseover="gutterOver(172)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',172);">&nbsp;</span
></td><td id="172"><a href="#172">172</a></td></tr
><tr id="gr_svn11_173"

 onmouseover="gutterOver(173)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',173);">&nbsp;</span
></td><td id="173"><a href="#173">173</a></td></tr
><tr id="gr_svn11_174"

 onmouseover="gutterOver(174)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',174);">&nbsp;</span
></td><td id="174"><a href="#174">174</a></td></tr
><tr id="gr_svn11_175"

 onmouseover="gutterOver(175)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',175);">&nbsp;</span
></td><td id="175"><a href="#175">175</a></td></tr
><tr id="gr_svn11_176"

 onmouseover="gutterOver(176)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',176);">&nbsp;</span
></td><td id="176"><a href="#176">176</a></td></tr
><tr id="gr_svn11_177"

 onmouseover="gutterOver(177)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',177);">&nbsp;</span
></td><td id="177"><a href="#177">177</a></td></tr
><tr id="gr_svn11_178"

 onmouseover="gutterOver(178)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',178);">&nbsp;</span
></td><td id="178"><a href="#178">178</a></td></tr
><tr id="gr_svn11_179"

 onmouseover="gutterOver(179)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',179);">&nbsp;</span
></td><td id="179"><a href="#179">179</a></td></tr
><tr id="gr_svn11_180"

 onmouseover="gutterOver(180)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',180);">&nbsp;</span
></td><td id="180"><a href="#180">180</a></td></tr
><tr id="gr_svn11_181"

 onmouseover="gutterOver(181)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',181);">&nbsp;</span
></td><td id="181"><a href="#181">181</a></td></tr
><tr id="gr_svn11_182"

 onmouseover="gutterOver(182)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',182);">&nbsp;</span
></td><td id="182"><a href="#182">182</a></td></tr
><tr id="gr_svn11_183"

 onmouseover="gutterOver(183)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',183);">&nbsp;</span
></td><td id="183"><a href="#183">183</a></td></tr
><tr id="gr_svn11_184"

 onmouseover="gutterOver(184)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',184);">&nbsp;</span
></td><td id="184"><a href="#184">184</a></td></tr
><tr id="gr_svn11_185"

 onmouseover="gutterOver(185)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',185);">&nbsp;</span
></td><td id="185"><a href="#185">185</a></td></tr
><tr id="gr_svn11_186"

 onmouseover="gutterOver(186)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',186);">&nbsp;</span
></td><td id="186"><a href="#186">186</a></td></tr
><tr id="gr_svn11_187"

 onmouseover="gutterOver(187)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',187);">&nbsp;</span
></td><td id="187"><a href="#187">187</a></td></tr
><tr id="gr_svn11_188"

 onmouseover="gutterOver(188)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',188);">&nbsp;</span
></td><td id="188"><a href="#188">188</a></td></tr
><tr id="gr_svn11_189"

 onmouseover="gutterOver(189)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',189);">&nbsp;</span
></td><td id="189"><a href="#189">189</a></td></tr
><tr id="gr_svn11_190"

 onmouseover="gutterOver(190)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',190);">&nbsp;</span
></td><td id="190"><a href="#190">190</a></td></tr
><tr id="gr_svn11_191"

 onmouseover="gutterOver(191)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',191);">&nbsp;</span
></td><td id="191"><a href="#191">191</a></td></tr
><tr id="gr_svn11_192"

 onmouseover="gutterOver(192)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',192);">&nbsp;</span
></td><td id="192"><a href="#192">192</a></td></tr
><tr id="gr_svn11_193"

 onmouseover="gutterOver(193)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',193);">&nbsp;</span
></td><td id="193"><a href="#193">193</a></td></tr
><tr id="gr_svn11_194"

 onmouseover="gutterOver(194)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',194);">&nbsp;</span
></td><td id="194"><a href="#194">194</a></td></tr
><tr id="gr_svn11_195"

 onmouseover="gutterOver(195)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',195);">&nbsp;</span
></td><td id="195"><a href="#195">195</a></td></tr
><tr id="gr_svn11_196"

 onmouseover="gutterOver(196)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',196);">&nbsp;</span
></td><td id="196"><a href="#196">196</a></td></tr
><tr id="gr_svn11_197"

 onmouseover="gutterOver(197)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',197);">&nbsp;</span
></td><td id="197"><a href="#197">197</a></td></tr
><tr id="gr_svn11_198"

 onmouseover="gutterOver(198)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',198);">&nbsp;</span
></td><td id="198"><a href="#198">198</a></td></tr
><tr id="gr_svn11_199"

 onmouseover="gutterOver(199)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',199);">&nbsp;</span
></td><td id="199"><a href="#199">199</a></td></tr
><tr id="gr_svn11_200"

 onmouseover="gutterOver(200)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',200);">&nbsp;</span
></td><td id="200"><a href="#200">200</a></td></tr
><tr id="gr_svn11_201"

 onmouseover="gutterOver(201)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',201);">&nbsp;</span
></td><td id="201"><a href="#201">201</a></td></tr
><tr id="gr_svn11_202"

 onmouseover="gutterOver(202)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',202);">&nbsp;</span
></td><td id="202"><a href="#202">202</a></td></tr
><tr id="gr_svn11_203"

 onmouseover="gutterOver(203)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',203);">&nbsp;</span
></td><td id="203"><a href="#203">203</a></td></tr
><tr id="gr_svn11_204"

 onmouseover="gutterOver(204)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',204);">&nbsp;</span
></td><td id="204"><a href="#204">204</a></td></tr
><tr id="gr_svn11_205"

 onmouseover="gutterOver(205)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',205);">&nbsp;</span
></td><td id="205"><a href="#205">205</a></td></tr
><tr id="gr_svn11_206"

 onmouseover="gutterOver(206)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',206);">&nbsp;</span
></td><td id="206"><a href="#206">206</a></td></tr
><tr id="gr_svn11_207"

 onmouseover="gutterOver(207)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',207);">&nbsp;</span
></td><td id="207"><a href="#207">207</a></td></tr
><tr id="gr_svn11_208"

 onmouseover="gutterOver(208)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',208);">&nbsp;</span
></td><td id="208"><a href="#208">208</a></td></tr
><tr id="gr_svn11_209"

 onmouseover="gutterOver(209)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',209);">&nbsp;</span
></td><td id="209"><a href="#209">209</a></td></tr
><tr id="gr_svn11_210"

 onmouseover="gutterOver(210)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',210);">&nbsp;</span
></td><td id="210"><a href="#210">210</a></td></tr
><tr id="gr_svn11_211"

 onmouseover="gutterOver(211)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',211);">&nbsp;</span
></td><td id="211"><a href="#211">211</a></td></tr
><tr id="gr_svn11_212"

 onmouseover="gutterOver(212)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',212);">&nbsp;</span
></td><td id="212"><a href="#212">212</a></td></tr
><tr id="gr_svn11_213"

 onmouseover="gutterOver(213)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',213);">&nbsp;</span
></td><td id="213"><a href="#213">213</a></td></tr
><tr id="gr_svn11_214"

 onmouseover="gutterOver(214)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',214);">&nbsp;</span
></td><td id="214"><a href="#214">214</a></td></tr
><tr id="gr_svn11_215"

 onmouseover="gutterOver(215)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',215);">&nbsp;</span
></td><td id="215"><a href="#215">215</a></td></tr
><tr id="gr_svn11_216"

 onmouseover="gutterOver(216)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',216);">&nbsp;</span
></td><td id="216"><a href="#216">216</a></td></tr
><tr id="gr_svn11_217"

 onmouseover="gutterOver(217)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',217);">&nbsp;</span
></td><td id="217"><a href="#217">217</a></td></tr
><tr id="gr_svn11_218"

 onmouseover="gutterOver(218)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',218);">&nbsp;</span
></td><td id="218"><a href="#218">218</a></td></tr
><tr id="gr_svn11_219"

 onmouseover="gutterOver(219)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',219);">&nbsp;</span
></td><td id="219"><a href="#219">219</a></td></tr
><tr id="gr_svn11_220"

 onmouseover="gutterOver(220)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',220);">&nbsp;</span
></td><td id="220"><a href="#220">220</a></td></tr
><tr id="gr_svn11_221"

 onmouseover="gutterOver(221)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',221);">&nbsp;</span
></td><td id="221"><a href="#221">221</a></td></tr
><tr id="gr_svn11_222"

 onmouseover="gutterOver(222)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',222);">&nbsp;</span
></td><td id="222"><a href="#222">222</a></td></tr
><tr id="gr_svn11_223"

 onmouseover="gutterOver(223)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',223);">&nbsp;</span
></td><td id="223"><a href="#223">223</a></td></tr
><tr id="gr_svn11_224"

 onmouseover="gutterOver(224)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',224);">&nbsp;</span
></td><td id="224"><a href="#224">224</a></td></tr
><tr id="gr_svn11_225"

 onmouseover="gutterOver(225)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',225);">&nbsp;</span
></td><td id="225"><a href="#225">225</a></td></tr
><tr id="gr_svn11_226"

 onmouseover="gutterOver(226)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',226);">&nbsp;</span
></td><td id="226"><a href="#226">226</a></td></tr
><tr id="gr_svn11_227"

 onmouseover="gutterOver(227)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',227);">&nbsp;</span
></td><td id="227"><a href="#227">227</a></td></tr
><tr id="gr_svn11_228"

 onmouseover="gutterOver(228)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',228);">&nbsp;</span
></td><td id="228"><a href="#228">228</a></td></tr
><tr id="gr_svn11_229"

 onmouseover="gutterOver(229)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',229);">&nbsp;</span
></td><td id="229"><a href="#229">229</a></td></tr
><tr id="gr_svn11_230"

 onmouseover="gutterOver(230)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',230);">&nbsp;</span
></td><td id="230"><a href="#230">230</a></td></tr
><tr id="gr_svn11_231"

 onmouseover="gutterOver(231)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',231);">&nbsp;</span
></td><td id="231"><a href="#231">231</a></td></tr
><tr id="gr_svn11_232"

 onmouseover="gutterOver(232)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',232);">&nbsp;</span
></td><td id="232"><a href="#232">232</a></td></tr
><tr id="gr_svn11_233"

 onmouseover="gutterOver(233)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',233);">&nbsp;</span
></td><td id="233"><a href="#233">233</a></td></tr
><tr id="gr_svn11_234"

 onmouseover="gutterOver(234)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',234);">&nbsp;</span
></td><td id="234"><a href="#234">234</a></td></tr
><tr id="gr_svn11_235"

 onmouseover="gutterOver(235)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',235);">&nbsp;</span
></td><td id="235"><a href="#235">235</a></td></tr
><tr id="gr_svn11_236"

 onmouseover="gutterOver(236)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',236);">&nbsp;</span
></td><td id="236"><a href="#236">236</a></td></tr
><tr id="gr_svn11_237"

 onmouseover="gutterOver(237)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',237);">&nbsp;</span
></td><td id="237"><a href="#237">237</a></td></tr
><tr id="gr_svn11_238"

 onmouseover="gutterOver(238)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',238);">&nbsp;</span
></td><td id="238"><a href="#238">238</a></td></tr
><tr id="gr_svn11_239"

 onmouseover="gutterOver(239)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',239);">&nbsp;</span
></td><td id="239"><a href="#239">239</a></td></tr
><tr id="gr_svn11_240"

 onmouseover="gutterOver(240)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',240);">&nbsp;</span
></td><td id="240"><a href="#240">240</a></td></tr
><tr id="gr_svn11_241"

 onmouseover="gutterOver(241)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',241);">&nbsp;</span
></td><td id="241"><a href="#241">241</a></td></tr
><tr id="gr_svn11_242"

 onmouseover="gutterOver(242)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',242);">&nbsp;</span
></td><td id="242"><a href="#242">242</a></td></tr
><tr id="gr_svn11_243"

 onmouseover="gutterOver(243)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',243);">&nbsp;</span
></td><td id="243"><a href="#243">243</a></td></tr
><tr id="gr_svn11_244"

 onmouseover="gutterOver(244)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',244);">&nbsp;</span
></td><td id="244"><a href="#244">244</a></td></tr
><tr id="gr_svn11_245"

 onmouseover="gutterOver(245)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',245);">&nbsp;</span
></td><td id="245"><a href="#245">245</a></td></tr
><tr id="gr_svn11_246"

 onmouseover="gutterOver(246)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',246);">&nbsp;</span
></td><td id="246"><a href="#246">246</a></td></tr
><tr id="gr_svn11_247"

 onmouseover="gutterOver(247)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',247);">&nbsp;</span
></td><td id="247"><a href="#247">247</a></td></tr
><tr id="gr_svn11_248"

 onmouseover="gutterOver(248)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',248);">&nbsp;</span
></td><td id="248"><a href="#248">248</a></td></tr
><tr id="gr_svn11_249"

 onmouseover="gutterOver(249)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',249);">&nbsp;</span
></td><td id="249"><a href="#249">249</a></td></tr
><tr id="gr_svn11_250"

 onmouseover="gutterOver(250)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',250);">&nbsp;</span
></td><td id="250"><a href="#250">250</a></td></tr
><tr id="gr_svn11_251"

 onmouseover="gutterOver(251)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',251);">&nbsp;</span
></td><td id="251"><a href="#251">251</a></td></tr
><tr id="gr_svn11_252"

 onmouseover="gutterOver(252)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',252);">&nbsp;</span
></td><td id="252"><a href="#252">252</a></td></tr
><tr id="gr_svn11_253"

 onmouseover="gutterOver(253)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',253);">&nbsp;</span
></td><td id="253"><a href="#253">253</a></td></tr
><tr id="gr_svn11_254"

 onmouseover="gutterOver(254)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',254);">&nbsp;</span
></td><td id="254"><a href="#254">254</a></td></tr
><tr id="gr_svn11_255"

 onmouseover="gutterOver(255)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',255);">&nbsp;</span
></td><td id="255"><a href="#255">255</a></td></tr
><tr id="gr_svn11_256"

 onmouseover="gutterOver(256)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',256);">&nbsp;</span
></td><td id="256"><a href="#256">256</a></td></tr
><tr id="gr_svn11_257"

 onmouseover="gutterOver(257)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',257);">&nbsp;</span
></td><td id="257"><a href="#257">257</a></td></tr
><tr id="gr_svn11_258"

 onmouseover="gutterOver(258)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',258);">&nbsp;</span
></td><td id="258"><a href="#258">258</a></td></tr
><tr id="gr_svn11_259"

 onmouseover="gutterOver(259)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',259);">&nbsp;</span
></td><td id="259"><a href="#259">259</a></td></tr
><tr id="gr_svn11_260"

 onmouseover="gutterOver(260)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',260);">&nbsp;</span
></td><td id="260"><a href="#260">260</a></td></tr
><tr id="gr_svn11_261"

 onmouseover="gutterOver(261)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',261);">&nbsp;</span
></td><td id="261"><a href="#261">261</a></td></tr
><tr id="gr_svn11_262"

 onmouseover="gutterOver(262)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',262);">&nbsp;</span
></td><td id="262"><a href="#262">262</a></td></tr
><tr id="gr_svn11_263"

 onmouseover="gutterOver(263)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',263);">&nbsp;</span
></td><td id="263"><a href="#263">263</a></td></tr
><tr id="gr_svn11_264"

 onmouseover="gutterOver(264)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',264);">&nbsp;</span
></td><td id="264"><a href="#264">264</a></td></tr
><tr id="gr_svn11_265"

 onmouseover="gutterOver(265)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',265);">&nbsp;</span
></td><td id="265"><a href="#265">265</a></td></tr
><tr id="gr_svn11_266"

 onmouseover="gutterOver(266)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',266);">&nbsp;</span
></td><td id="266"><a href="#266">266</a></td></tr
><tr id="gr_svn11_267"

 onmouseover="gutterOver(267)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',267);">&nbsp;</span
></td><td id="267"><a href="#267">267</a></td></tr
><tr id="gr_svn11_268"

 onmouseover="gutterOver(268)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',268);">&nbsp;</span
></td><td id="268"><a href="#268">268</a></td></tr
><tr id="gr_svn11_269"

 onmouseover="gutterOver(269)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',269);">&nbsp;</span
></td><td id="269"><a href="#269">269</a></td></tr
><tr id="gr_svn11_270"

 onmouseover="gutterOver(270)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',270);">&nbsp;</span
></td><td id="270"><a href="#270">270</a></td></tr
><tr id="gr_svn11_271"

 onmouseover="gutterOver(271)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',271);">&nbsp;</span
></td><td id="271"><a href="#271">271</a></td></tr
><tr id="gr_svn11_272"

 onmouseover="gutterOver(272)"

><td><span title="Add comment" onclick="codereviews.startEdit('svn11',272);">&nbsp;</span
></td><td id="272"><a href="#272">272</a></td></tr
></table></pre>
<pre><table width="100%"><tr class="nocursor"><td></td></tr></table></pre>
</td>
<td id="lines">
<pre><table width="100%"><tr class="cursor_stop cursor_hidden"><td></td></tr></table></pre>
<pre class="prettyprint lang-cs"><table id="src_table_0"><tr
id=sl_svn11_1

 onmouseover="gutterOver(1)"

><td class="source">using System;<br></td></tr
><tr
id=sl_svn11_2

 onmouseover="gutterOver(2)"

><td class="source">using System.Collections.Generic;<br></td></tr
><tr
id=sl_svn11_3

 onmouseover="gutterOver(3)"

><td class="source">using System.Data;<br></td></tr
><tr
id=sl_svn11_4

 onmouseover="gutterOver(4)"

><td class="source">using System.Data.SQLite;<br></td></tr
><tr
id=sl_svn11_5

 onmouseover="gutterOver(5)"

><td class="source">using System.Linq;<br></td></tr
><tr
id=sl_svn11_6

 onmouseover="gutterOver(6)"

><td class="source">using System.Text;<br></td></tr
><tr
id=sl_svn11_7

 onmouseover="gutterOver(7)"

><td class="source">//using Finisar.SQLite;<br></td></tr
><tr
id=sl_svn11_8

 onmouseover="gutterOver(8)"

><td class="source">//using Microsoft.Samples.Kinect.ColorBasics.kFrame;<br></td></tr
><tr
id=sl_svn11_9

 onmouseover="gutterOver(9)"

><td class="source">//using System.Windows.Forms;<br></td></tr
><tr
id=sl_svn11_10

 onmouseover="gutterOver(10)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_11

 onmouseover="gutterOver(11)"

><td class="source">namespace Microsoft.Samples.Kinect.ColorBasics<br></td></tr
><tr
id=sl_svn11_12

 onmouseover="gutterOver(12)"

><td class="source">{<br></td></tr
><tr
id=sl_svn11_13

 onmouseover="gutterOver(13)"

><td class="source">    public class SQLiteDB<br></td></tr
><tr
id=sl_svn11_14

 onmouseover="gutterOver(14)"

><td class="source">    {<br></td></tr
><tr
id=sl_svn11_15

 onmouseover="gutterOver(15)"

><td class="source">        // Three basic SQLite objects:<br></td></tr
><tr
id=sl_svn11_16

 onmouseover="gutterOver(16)"

><td class="source">        public SQLiteConnection sqConnection;<br></td></tr
><tr
id=sl_svn11_17

 onmouseover="gutterOver(17)"

><td class="source">        public SQLiteCommand sqCmd;<br></td></tr
><tr
id=sl_svn11_18

 onmouseover="gutterOver(18)"

><td class="source">        public SQLiteDataReader sqDatareader;<br></td></tr
><tr
id=sl_svn11_19

 onmouseover="gutterOver(19)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_20

 onmouseover="gutterOver(20)"

><td class="source">        public string queries;<br></td></tr
><tr
id=sl_svn11_21

 onmouseover="gutterOver(21)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_22

 onmouseover="gutterOver(22)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_23

 onmouseover="gutterOver(23)"

><td class="source">        public SQLiteDB()<br></td></tr
><tr
id=sl_svn11_24

 onmouseover="gutterOver(24)"

><td class="source">        {<br></td></tr
><tr
id=sl_svn11_25

 onmouseover="gutterOver(25)"

><td class="source">            //this.onCreate();<br></td></tr
><tr
id=sl_svn11_26

 onmouseover="gutterOver(26)"

><td class="source">        }<br></td></tr
><tr
id=sl_svn11_27

 onmouseover="gutterOver(27)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_28

 onmouseover="gutterOver(28)"

><td class="source">        //Open and create database name<br></td></tr
><tr
id=sl_svn11_29

 onmouseover="gutterOver(29)"

><td class="source">        public void open()<br></td></tr
><tr
id=sl_svn11_30

 onmouseover="gutterOver(30)"

><td class="source">        {<br></td></tr
><tr
id=sl_svn11_31

 onmouseover="gutterOver(31)"

><td class="source">            System.Console.WriteLine(&quot;Opening Database&quot;);<br></td></tr
><tr
id=sl_svn11_32

 onmouseover="gutterOver(32)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_33

 onmouseover="gutterOver(33)"

><td class="source">            //original reference &quot;Data Source=test.db;Version=3;New=True;Compress=True;&quot;<br></td></tr
><tr
id=sl_svn11_34

 onmouseover="gutterOver(34)"

><td class="source">            // code to log in (does nothing locally)Uid = admin; Pwd = admin;<br></td></tr
><tr
id=sl_svn11_35

 onmouseover="gutterOver(35)"

><td class="source">            string dbsetup = String.Format(&quot;Data Source={0}{1}.db;Version=3;New=True;Compress=True;&quot;, System.Environment.MachineName, DateTime.Now.ToString(&quot;ddMMyy_HHmmtt&quot;));<br></td></tr
><tr
id=sl_svn11_36

 onmouseover="gutterOver(36)"

><td class="source">            //dbName = String.Format(&quot;Data Source=&quot; + DateTime.Now.ToString(&quot;ddMMyyyy_HHMMtt&quot;) + &quot;.db;Version=3;New=True;Compress=True;&quot;; <br></td></tr
><tr
id=sl_svn11_37

 onmouseover="gutterOver(37)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_38

 onmouseover="gutterOver(38)"

><td class="source">            sqConnection = new SQLiteConnection(dbsetup);<br></td></tr
><tr
id=sl_svn11_39

 onmouseover="gutterOver(39)"

><td class="source">            try<br></td></tr
><tr
id=sl_svn11_40

 onmouseover="gutterOver(40)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_41

 onmouseover="gutterOver(41)"

><td class="source">                //sqConnection = new SQLiteConnection(&quot;Data Source=&quot; + timestamp + &quot;.sqlite;Version=3;New=True;Compress=True;&quot;);<br></td></tr
><tr
id=sl_svn11_42

 onmouseover="gutterOver(42)"

><td class="source">                sqConnection.Open();<br></td></tr
><tr
id=sl_svn11_43

 onmouseover="gutterOver(43)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_44

 onmouseover="gutterOver(44)"

><td class="source">            catch (Exception e)<br></td></tr
><tr
id=sl_svn11_45

 onmouseover="gutterOver(45)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_46

 onmouseover="gutterOver(46)"

><td class="source">                System.Console.WriteLine(e);<br></td></tr
><tr
id=sl_svn11_47

 onmouseover="gutterOver(47)"

><td class="source">                System.Console.WriteLine(&quot;DB open/creation failed&quot;);<br></td></tr
><tr
id=sl_svn11_48

 onmouseover="gutterOver(48)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_49

 onmouseover="gutterOver(49)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_50

 onmouseover="gutterOver(50)"

><td class="source">            System.Console.WriteLine(&quot;DB Open&quot;);<br></td></tr
><tr
id=sl_svn11_51

 onmouseover="gutterOver(51)"

><td class="source">        }<br></td></tr
><tr
id=sl_svn11_52

 onmouseover="gutterOver(52)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_53

 onmouseover="gutterOver(53)"

><td class="source">        public void close()<br></td></tr
><tr
id=sl_svn11_54

 onmouseover="gutterOver(54)"

><td class="source">        {<br></td></tr
><tr
id=sl_svn11_55

 onmouseover="gutterOver(55)"

><td class="source">            sqConnection.Close();<br></td></tr
><tr
id=sl_svn11_56

 onmouseover="gutterOver(56)"

><td class="source">        }<br></td></tr
><tr
id=sl_svn11_57

 onmouseover="gutterOver(57)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_58

 onmouseover="gutterOver(58)"

><td class="source">        public void initTables()<br></td></tr
><tr
id=sl_svn11_59

 onmouseover="gutterOver(59)"

><td class="source">        {<br></td></tr
><tr
id=sl_svn11_60

 onmouseover="gutterOver(60)"

><td class="source">            System.Console.WriteLine(&quot;Initializing Tables&quot;);<br></td></tr
><tr
id=sl_svn11_61

 onmouseover="gutterOver(61)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_62

 onmouseover="gutterOver(62)"

><td class="source">            try<br></td></tr
><tr
id=sl_svn11_63

 onmouseover="gutterOver(63)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_64

 onmouseover="gutterOver(64)"

><td class="source">                //table created when dll starts to keep track of unique identifiers for the program<br></td></tr
><tr
id=sl_svn11_65

 onmouseover="gutterOver(65)"

><td class="source">                queries = &quot;CREATE TABLE headerManager (machine VARCHAR(30) PRIMARY KEY, timestamp VARCHAR(30), mode INTEGER);&quot;;<br></td></tr
><tr
id=sl_svn11_66

 onmouseover="gutterOver(66)"

><td class="source">                sqCmd = new SQLiteCommand(queries, sqConnection);<br></td></tr
><tr
id=sl_svn11_67

 onmouseover="gutterOver(67)"

><td class="source">                sqCmd.ExecuteNonQuery();<br></td></tr
><tr
id=sl_svn11_68

 onmouseover="gutterOver(68)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_69

 onmouseover="gutterOver(69)"

><td class="source">                //table for running time, x,y,z values, and permittable variance values<br></td></tr
><tr
id=sl_svn11_70

 onmouseover="gutterOver(70)"

><td class="source">                queries = &quot;CREATE TABLE frameManager (session INTEGER, frame INTEGER, shoulder VARCHAR(1), accept VARCHAR(1), tx DOUBLE, ty DOUBLE, tz DOUBLE, sx DOUBLE, sy DOUBLE, sz DOUBLE, PRIMARY KEY(session, frame));&quot;;<br></td></tr
><tr
id=sl_svn11_71

 onmouseover="gutterOver(71)"

><td class="source">                sqCmd = new SQLiteCommand(queries, sqConnection);<br></td></tr
><tr
id=sl_svn11_72

 onmouseover="gutterOver(72)"

><td class="source">                sqCmd.ExecuteNonQuery();<br></td></tr
><tr
id=sl_svn11_73

 onmouseover="gutterOver(73)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_74

 onmouseover="gutterOver(74)"

><td class="source">                queries = &quot;CREATE TABLE boxManager (session INTEGER, part VARCHAR(10), minx DOUBLE, miny DOUBLE, minz DOUBLE, maxx DOUBLE, maxy DOUBLE, maxz double, PRIMARY KEY (session, part));&quot;;<br></td></tr
><tr
id=sl_svn11_75

 onmouseover="gutterOver(75)"

><td class="source">                sqCmd = new SQLiteCommand(queries, sqConnection);<br></td></tr
><tr
id=sl_svn11_76

 onmouseover="gutterOver(76)"

><td class="source">                sqCmd.ExecuteNonQuery();<br></td></tr
><tr
id=sl_svn11_77

 onmouseover="gutterOver(77)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_78

 onmouseover="gutterOver(78)"

><td class="source">                System.Console.WriteLine(&quot;Tables Created&quot;);<br></td></tr
><tr
id=sl_svn11_79

 onmouseover="gutterOver(79)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_80

 onmouseover="gutterOver(80)"

><td class="source">                //Put header into database<br></td></tr
><tr
id=sl_svn11_81

 onmouseover="gutterOver(81)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_82

 onmouseover="gutterOver(82)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_83

 onmouseover="gutterOver(83)"

><td class="source">            catch (Exception e)<br></td></tr
><tr
id=sl_svn11_84

 onmouseover="gutterOver(84)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_85

 onmouseover="gutterOver(85)"

><td class="source">                System.Console.WriteLine(e);<br></td></tr
><tr
id=sl_svn11_86

 onmouseover="gutterOver(86)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_87

 onmouseover="gutterOver(87)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_88

 onmouseover="gutterOver(88)"

><td class="source">        }<br></td></tr
><tr
id=sl_svn11_89

 onmouseover="gutterOver(89)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_90

 onmouseover="gutterOver(90)"

><td class="source">        public void createHeader(int Mode)<br></td></tr
><tr
id=sl_svn11_91

 onmouseover="gutterOver(91)"

><td class="source">        {<br></td></tr
><tr
id=sl_svn11_92

 onmouseover="gutterOver(92)"

><td class="source">            System.Console.WriteLine(&quot;Creating new header&quot;);<br></td></tr
><tr
id=sl_svn11_93

 onmouseover="gutterOver(93)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_94

 onmouseover="gutterOver(94)"

><td class="source">            try<br></td></tr
><tr
id=sl_svn11_95

 onmouseover="gutterOver(95)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_96

 onmouseover="gutterOver(96)"

><td class="source">                //Put header into database<br></td></tr
><tr
id=sl_svn11_97

 onmouseover="gutterOver(97)"

><td class="source">                string machine = System.Environment.MachineName;<br></td></tr
><tr
id=sl_svn11_98

 onmouseover="gutterOver(98)"

><td class="source">                string time = DateTime.Now.ToString(&quot;HH_MM_tt&quot;);<br></td></tr
><tr
id=sl_svn11_99

 onmouseover="gutterOver(99)"

><td class="source">                //mode is given in function<br></td></tr
><tr
id=sl_svn11_100

 onmouseover="gutterOver(100)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_101

 onmouseover="gutterOver(101)"

><td class="source">                //queries = &quot;INSERT INTO sessionManager (user, timestamp, sessionType) VALUES (&#39;&quot; + machine + &quot;&#39;, &#39;&quot; + date + &quot;&#39;, 1);&quot;;<br></td></tr
><tr
id=sl_svn11_102

 onmouseover="gutterOver(102)"

><td class="source">                queries = &quot;INSERT INTO headerManager (machine, timestamp, mode) VALUES (@machine, @time, @mode);&quot;;<br></td></tr
><tr
id=sl_svn11_103

 onmouseover="gutterOver(103)"

><td class="source">                sqCmd = new SQLiteCommand(queries, sqConnection);<br></td></tr
><tr
id=sl_svn11_104

 onmouseover="gutterOver(104)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@machine&quot;, machine);<br></td></tr
><tr
id=sl_svn11_105

 onmouseover="gutterOver(105)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@time&quot;, time);<br></td></tr
><tr
id=sl_svn11_106

 onmouseover="gutterOver(106)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@mode&quot;, Mode);<br></td></tr
><tr
id=sl_svn11_107

 onmouseover="gutterOver(107)"

><td class="source">                sqCmd.ExecuteNonQuery();<br></td></tr
><tr
id=sl_svn11_108

 onmouseover="gutterOver(108)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_109

 onmouseover="gutterOver(109)"

><td class="source">            catch (Exception e)<br></td></tr
><tr
id=sl_svn11_110

 onmouseover="gutterOver(110)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_111

 onmouseover="gutterOver(111)"

><td class="source">                System.Console.WriteLine(e);<br></td></tr
><tr
id=sl_svn11_112

 onmouseover="gutterOver(112)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_113

 onmouseover="gutterOver(113)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_114

 onmouseover="gutterOver(114)"

><td class="source">            System.Console.WriteLine(&quot;Header Insert End&quot;);<br></td></tr
><tr
id=sl_svn11_115

 onmouseover="gutterOver(115)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_116

 onmouseover="gutterOver(116)"

><td class="source">        }<br></td></tr
><tr
id=sl_svn11_117

 onmouseover="gutterOver(117)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_118

 onmouseover="gutterOver(118)"

><td class="source">        public void addFrame(kFrame frame, int sessionNum)<br></td></tr
><tr
id=sl_svn11_119

 onmouseover="gutterOver(119)"

><td class="source">        {<br></td></tr
><tr
id=sl_svn11_120

 onmouseover="gutterOver(120)"

><td class="source">            System.Console.WriteLine(&quot;New frame&quot;);<br></td></tr
><tr
id=sl_svn11_121

 onmouseover="gutterOver(121)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_122

 onmouseover="gutterOver(122)"

><td class="source">            try<br></td></tr
><tr
id=sl_svn11_123

 onmouseover="gutterOver(123)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_124

 onmouseover="gutterOver(124)"

><td class="source">                //queries = &quot;INSERT INTO frameManager (frame, x, y, z, variance) VALUES (&quot; + frame.getFrame() + &quot;, &quot; + frame.getX() + &quot;, &quot; + frame.getY() + &quot;, &quot; + frame.getZ() + &quot;, &quot; + frame.getVariance() + &quot;);&quot;;<br></td></tr
><tr
id=sl_svn11_125

 onmouseover="gutterOver(125)"

><td class="source">                queries = &quot;INSERT INTO frameManager (session, frame, shoulder, accept, tx, ty, tz, sx, sy, sz) VALUES (@session, @frame, @shoulder, @accept, @tx, @ty, @tz, @sx, @sy, @sz);&quot;;<br></td></tr
><tr
id=sl_svn11_126

 onmouseover="gutterOver(126)"

><td class="source">                sqCmd = new SQLiteCommand(queries, sqConnection);<br></td></tr
><tr
id=sl_svn11_127

 onmouseover="gutterOver(127)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@session&quot;, sessionNum);<br></td></tr
><tr
id=sl_svn11_128

 onmouseover="gutterOver(128)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@frame&quot;, frame.getFrame());<br></td></tr
><tr
id=sl_svn11_129

 onmouseover="gutterOver(129)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@shoulder&quot;, frame.getShoulder());<br></td></tr
><tr
id=sl_svn11_130

 onmouseover="gutterOver(130)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@accept&quot;, frame.getAccept());<br></td></tr
><tr
id=sl_svn11_131

 onmouseover="gutterOver(131)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@tx&quot;, frame.getTX());<br></td></tr
><tr
id=sl_svn11_132

 onmouseover="gutterOver(132)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@ty&quot;, frame.getTY());<br></td></tr
><tr
id=sl_svn11_133

 onmouseover="gutterOver(133)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@tz&quot;, frame.getTZ());<br></td></tr
><tr
id=sl_svn11_134

 onmouseover="gutterOver(134)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@sx&quot;, frame.getSX());<br></td></tr
><tr
id=sl_svn11_135

 onmouseover="gutterOver(135)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@sy&quot;, frame.getSY());<br></td></tr
><tr
id=sl_svn11_136

 onmouseover="gutterOver(136)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@sz&quot;, frame.getSZ());<br></td></tr
><tr
id=sl_svn11_137

 onmouseover="gutterOver(137)"

><td class="source">                sqCmd.ExecuteNonQuery();<br></td></tr
><tr
id=sl_svn11_138

 onmouseover="gutterOver(138)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_139

 onmouseover="gutterOver(139)"

><td class="source">            catch (Exception e)<br></td></tr
><tr
id=sl_svn11_140

 onmouseover="gutterOver(140)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_141

 onmouseover="gutterOver(141)"

><td class="source">                System.Console.WriteLine(e);<br></td></tr
><tr
id=sl_svn11_142

 onmouseover="gutterOver(142)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_143

 onmouseover="gutterOver(143)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_144

 onmouseover="gutterOver(144)"

><td class="source">            System.Console.WriteLine(&quot;New frame END&quot;);<br></td></tr
><tr
id=sl_svn11_145

 onmouseover="gutterOver(145)"

><td class="source">        }<br></td></tr
><tr
id=sl_svn11_146

 onmouseover="gutterOver(146)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_147

 onmouseover="gutterOver(147)"

><td class="source">        public List&lt;kFrame&gt; getAllkFrame(int sessionid)<br></td></tr
><tr
id=sl_svn11_148

 onmouseover="gutterOver(148)"

><td class="source">        {<br></td></tr
><tr
id=sl_svn11_149

 onmouseover="gutterOver(149)"

><td class="source">            System.Console.WriteLine(&quot;Get ALL frames&quot;);<br></td></tr
><tr
id=sl_svn11_150

 onmouseover="gutterOver(150)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_151

 onmouseover="gutterOver(151)"

><td class="source">            List&lt;kFrame&gt; frameValues = new List&lt;kFrame&gt;();<br></td></tr
><tr
id=sl_svn11_152

 onmouseover="gutterOver(152)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_153

 onmouseover="gutterOver(153)"

><td class="source">            try<br></td></tr
><tr
id=sl_svn11_154

 onmouseover="gutterOver(154)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_155

 onmouseover="gutterOver(155)"

><td class="source">                queries = &quot;SELECT * FROM frameManager WHERE session=@sessionid&quot;;<br></td></tr
><tr
id=sl_svn11_156

 onmouseover="gutterOver(156)"

><td class="source">                sqCmd = new SQLiteCommand(queries, sqConnection);<br></td></tr
><tr
id=sl_svn11_157

 onmouseover="gutterOver(157)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@sessionid&quot;, sessionid);<br></td></tr
><tr
id=sl_svn11_158

 onmouseover="gutterOver(158)"

><td class="source">                sqDatareader = sqCmd.ExecuteReader();<br></td></tr
><tr
id=sl_svn11_159

 onmouseover="gutterOver(159)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_160

 onmouseover="gutterOver(160)"

><td class="source">                while(sqDatareader.Read())<br></td></tr
><tr
id=sl_svn11_161

 onmouseover="gutterOver(161)"

><td class="source">                {<br></td></tr
><tr
id=sl_svn11_162

 onmouseover="gutterOver(162)"

><td class="source">                    //int fnum = (int)sqDatareader[&quot;frame&quot;];<br></td></tr
><tr
id=sl_svn11_163

 onmouseover="gutterOver(163)"

><td class="source">                    kFrame frame = new kFrame((int)sqDatareader[&quot;session&quot;], (int)sqDatareader[&quot;frame&quot;], (string)sqDatareader[&quot;shoulder&quot;], (string)sqDatareader[&quot;accept&quot;], (double)sqDatareader[&quot;tx&quot;], (double)sqDatareader[&quot;ty&quot;], (double)sqDatareader[&quot;tz&quot;], (double)sqDatareader[&quot;sx&quot;], (double)sqDatareader[&quot;sy&quot;], (double)sqDatareader[&quot;sz&quot;]);<br></td></tr
><tr
id=sl_svn11_164

 onmouseover="gutterOver(164)"

><td class="source">                    frameValues.Add(frame);<br></td></tr
><tr
id=sl_svn11_165

 onmouseover="gutterOver(165)"

><td class="source">                }<br></td></tr
><tr
id=sl_svn11_166

 onmouseover="gutterOver(166)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_167

 onmouseover="gutterOver(167)"

><td class="source">            catch (Exception e)<br></td></tr
><tr
id=sl_svn11_168

 onmouseover="gutterOver(168)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_169

 onmouseover="gutterOver(169)"

><td class="source">                System.Console.WriteLine(e);<br></td></tr
><tr
id=sl_svn11_170

 onmouseover="gutterOver(170)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_171

 onmouseover="gutterOver(171)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_172

 onmouseover="gutterOver(172)"

><td class="source">            System.Console.WriteLine(&quot;Returning ALL frames&quot;);<br></td></tr
><tr
id=sl_svn11_173

 onmouseover="gutterOver(173)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_174

 onmouseover="gutterOver(174)"

><td class="source">            return frameValues;<br></td></tr
><tr
id=sl_svn11_175

 onmouseover="gutterOver(175)"

><td class="source">        }<br></td></tr
><tr
id=sl_svn11_176

 onmouseover="gutterOver(176)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_177

 onmouseover="gutterOver(177)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_178

 onmouseover="gutterOver(178)"

><td class="source">        public kFrame getkFrame(int framenum, int sessionid)<br></td></tr
><tr
id=sl_svn11_179

 onmouseover="gutterOver(179)"

><td class="source">        {<br></td></tr
><tr
id=sl_svn11_180

 onmouseover="gutterOver(180)"

><td class="source">            System.Console.WriteLine(&quot;Get frame&quot;);<br></td></tr
><tr
id=sl_svn11_181

 onmouseover="gutterOver(181)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_182

 onmouseover="gutterOver(182)"

><td class="source">            kFrame frame = null;<br></td></tr
><tr
id=sl_svn11_183

 onmouseover="gutterOver(183)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_184

 onmouseover="gutterOver(184)"

><td class="source">            try<br></td></tr
><tr
id=sl_svn11_185

 onmouseover="gutterOver(185)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_186

 onmouseover="gutterOver(186)"

><td class="source">                queries = &quot;SELECT * FROM frameManager WHERE frame=@frame, and session=@sessionid&quot;;<br></td></tr
><tr
id=sl_svn11_187

 onmouseover="gutterOver(187)"

><td class="source">                sqCmd = new SQLiteCommand(queries, sqConnection);<br></td></tr
><tr
id=sl_svn11_188

 onmouseover="gutterOver(188)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@frame&quot;, framenum);<br></td></tr
><tr
id=sl_svn11_189

 onmouseover="gutterOver(189)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@sessionid&quot;, sessionid);<br></td></tr
><tr
id=sl_svn11_190

 onmouseover="gutterOver(190)"

><td class="source">                sqDatareader = sqCmd.ExecuteReader();<br></td></tr
><tr
id=sl_svn11_191

 onmouseover="gutterOver(191)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_192

 onmouseover="gutterOver(192)"

><td class="source">                sqDatareader.Read();<br></td></tr
><tr
id=sl_svn11_193

 onmouseover="gutterOver(193)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_194

 onmouseover="gutterOver(194)"

><td class="source">                frame = new kFrame((int)sqDatareader[&quot;session&quot;], (int)sqDatareader[&quot;frame&quot;], (string)sqDatareader[&quot;shoulder&quot;], (string)sqDatareader[&quot;accept&quot;], (double)sqDatareader[&quot;tx&quot;], (double)sqDatareader[&quot;ty&quot;], (double)sqDatareader[&quot;tz&quot;], (double)sqDatareader[&quot;sx&quot;], (double)sqDatareader[&quot;sy&quot;], (double)sqDatareader[&quot;sz&quot;]);<br></td></tr
><tr
id=sl_svn11_195

 onmouseover="gutterOver(195)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_196

 onmouseover="gutterOver(196)"

><td class="source">            catch (Exception e)<br></td></tr
><tr
id=sl_svn11_197

 onmouseover="gutterOver(197)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_198

 onmouseover="gutterOver(198)"

><td class="source">                System.Console.WriteLine(e);<br></td></tr
><tr
id=sl_svn11_199

 onmouseover="gutterOver(199)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_200

 onmouseover="gutterOver(200)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_201

 onmouseover="gutterOver(201)"

><td class="source">            System.Console.WriteLine(&quot;Return found frame&quot;);<br></td></tr
><tr
id=sl_svn11_202

 onmouseover="gutterOver(202)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_203

 onmouseover="gutterOver(203)"

><td class="source">            return frame;<br></td></tr
><tr
id=sl_svn11_204

 onmouseover="gutterOver(204)"

><td class="source">        }<br></td></tr
><tr
id=sl_svn11_205

 onmouseover="gutterOver(205)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_206

 onmouseover="gutterOver(206)"

><td class="source">        public void createBoxes(kFrame frame)<br></td></tr
><tr
id=sl_svn11_207

 onmouseover="gutterOver(207)"

><td class="source">        {<br></td></tr
><tr
id=sl_svn11_208

 onmouseover="gutterOver(208)"

><td class="source">            System.Console.WriteLine(&quot;New frame&quot;);<br></td></tr
><tr
id=sl_svn11_209

 onmouseover="gutterOver(209)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_210

 onmouseover="gutterOver(210)"

><td class="source">            try<br></td></tr
><tr
id=sl_svn11_211

 onmouseover="gutterOver(211)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_212

 onmouseover="gutterOver(212)"

><td class="source">                //insert 1 part at a time so the SQL doesn&#39;t look awful<br></td></tr
><tr
id=sl_svn11_213

 onmouseover="gutterOver(213)"

><td class="source">                //Shoulder First<br></td></tr
><tr
id=sl_svn11_214

 onmouseover="gutterOver(214)"

><td class="source">                queries = &quot;INSERT INTO boxManager (session, part, minx, miny, minz, maxx, maxy, maxz) VALUES (@session, @part, @minx, @miny, @minz, @maxx, @maxy, @maxz);&quot;;<br></td></tr
><tr
id=sl_svn11_215

 onmouseover="gutterOver(215)"

><td class="source">                sqCmd = new SQLiteCommand(queries, sqConnection);<br></td></tr
><tr
id=sl_svn11_216

 onmouseover="gutterOver(216)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@session&quot;, frame.getSession());<br></td></tr
><tr
id=sl_svn11_217

 onmouseover="gutterOver(217)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@part&quot;, &quot;Shoulder&quot;);<br></td></tr
><tr
id=sl_svn11_218

 onmouseover="gutterOver(218)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@minx&quot;, frame.getSX() * .75);<br></td></tr
><tr
id=sl_svn11_219

 onmouseover="gutterOver(219)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@miny&quot;, frame.getSY() * .75);<br></td></tr
><tr
id=sl_svn11_220

 onmouseover="gutterOver(220)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@minz&quot;, frame.getSZ() * .75);<br></td></tr
><tr
id=sl_svn11_221

 onmouseover="gutterOver(221)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@maxx&quot;, frame.getSX() * 1.25);<br></td></tr
><tr
id=sl_svn11_222

 onmouseover="gutterOver(222)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@maxy&quot;, frame.getSY() * 1.25);<br></td></tr
><tr
id=sl_svn11_223

 onmouseover="gutterOver(223)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@maxz&quot;, frame.getSZ() * 1.25);<br></td></tr
><tr
id=sl_svn11_224

 onmouseover="gutterOver(224)"

><td class="source">                sqCmd.ExecuteNonQuery();<br></td></tr
><tr
id=sl_svn11_225

 onmouseover="gutterOver(225)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_226

 onmouseover="gutterOver(226)"

><td class="source">                //Torso Second<br></td></tr
><tr
id=sl_svn11_227

 onmouseover="gutterOver(227)"

><td class="source">                queries = &quot;INSERT INTO boxManager (session, part, minx, miny, minz, maxx, maxy, maxz) VALUES (@session, @part, @minx, @miny, @minz, @maxx, @maxy, @maxz);&quot;;<br></td></tr
><tr
id=sl_svn11_228

 onmouseover="gutterOver(228)"

><td class="source">                sqCmd = new SQLiteCommand(queries, sqConnection);<br></td></tr
><tr
id=sl_svn11_229

 onmouseover="gutterOver(229)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@session&quot;, frame.getSession());<br></td></tr
><tr
id=sl_svn11_230

 onmouseover="gutterOver(230)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@part&quot;, &quot;Torso&quot;);<br></td></tr
><tr
id=sl_svn11_231

 onmouseover="gutterOver(231)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@minx&quot;, frame.getTX() * .75);<br></td></tr
><tr
id=sl_svn11_232

 onmouseover="gutterOver(232)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@miny&quot;, frame.getTY() * .75);<br></td></tr
><tr
id=sl_svn11_233

 onmouseover="gutterOver(233)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@minz&quot;, frame.getTZ() * .75);<br></td></tr
><tr
id=sl_svn11_234

 onmouseover="gutterOver(234)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@maxx&quot;, frame.getTX() * 1.25);<br></td></tr
><tr
id=sl_svn11_235

 onmouseover="gutterOver(235)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@maxy&quot;, frame.getTY() * 1.25);<br></td></tr
><tr
id=sl_svn11_236

 onmouseover="gutterOver(236)"

><td class="source">                sqCmd.Parameters.AddWithValue(&quot;@maxz&quot;, frame.getTZ() * 1.25);<br></td></tr
><tr
id=sl_svn11_237

 onmouseover="gutterOver(237)"

><td class="source">                sqCmd.ExecuteNonQuery();<br></td></tr
><tr
id=sl_svn11_238

 onmouseover="gutterOver(238)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_239

 onmouseover="gutterOver(239)"

><td class="source">            catch (Exception e)<br></td></tr
><tr
id=sl_svn11_240

 onmouseover="gutterOver(240)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_241

 onmouseover="gutterOver(241)"

><td class="source">                System.Console.WriteLine(e);<br></td></tr
><tr
id=sl_svn11_242

 onmouseover="gutterOver(242)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_243

 onmouseover="gutterOver(243)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_244

 onmouseover="gutterOver(244)"

><td class="source">            System.Console.WriteLine(&quot;New frame END&quot;);<br></td></tr
><tr
id=sl_svn11_245

 onmouseover="gutterOver(245)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_246

 onmouseover="gutterOver(246)"

><td class="source">        }<br></td></tr
><tr
id=sl_svn11_247

 onmouseover="gutterOver(247)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_248

 onmouseover="gutterOver(248)"

><td class="source">        public void printFrames(int sessionid)<br></td></tr
><tr
id=sl_svn11_249

 onmouseover="gutterOver(249)"

><td class="source">        {<br></td></tr
><tr
id=sl_svn11_250

 onmouseover="gutterOver(250)"

><td class="source">            System.Console.WriteLine(&quot;Print Frames&quot;);<br></td></tr
><tr
id=sl_svn11_251

 onmouseover="gutterOver(251)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_252

 onmouseover="gutterOver(252)"

><td class="source">            try<br></td></tr
><tr
id=sl_svn11_253

 onmouseover="gutterOver(253)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_254

 onmouseover="gutterOver(254)"

><td class="source">                queries = &quot;SELECT * from frameManager&quot;;<br></td></tr
><tr
id=sl_svn11_255

 onmouseover="gutterOver(255)"

><td class="source">                sqCmd = new SQLiteCommand(queries, sqConnection);<br></td></tr
><tr
id=sl_svn11_256

 onmouseover="gutterOver(256)"

><td class="source">                sqDatareader = sqCmd.ExecuteReader();<br></td></tr
><tr
id=sl_svn11_257

 onmouseover="gutterOver(257)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_258

 onmouseover="gutterOver(258)"

><td class="source">                while (sqDatareader.Read())<br></td></tr
><tr
id=sl_svn11_259

 onmouseover="gutterOver(259)"

><td class="source">                {<br></td></tr
><tr
id=sl_svn11_260

 onmouseover="gutterOver(260)"

><td class="source">                    System.Console.WriteLine(&quot;Frame #&quot; + sqDatareader[&quot;frame&quot;] + &quot;: Shoulder: &quot; + sqDatareader[&quot;shoulder&quot;] + &quot;, Acceptable Range: &quot; + sqDatareader[&quot;accept&quot;] + &quot;, SessionID: &quot; + sqDatareader[&quot;session&quot;] + &quot;, two random vals: &quot; + sqDatareader[&quot;tx&quot;] + &quot; &quot; + sqDatareader[&quot;sz&quot;]);<br></td></tr
><tr
id=sl_svn11_261

 onmouseover="gutterOver(261)"

><td class="source">                }<br></td></tr
><tr
id=sl_svn11_262

 onmouseover="gutterOver(262)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_263

 onmouseover="gutterOver(263)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_264

 onmouseover="gutterOver(264)"

><td class="source">            catch (Exception e)<br></td></tr
><tr
id=sl_svn11_265

 onmouseover="gutterOver(265)"

><td class="source">            {<br></td></tr
><tr
id=sl_svn11_266

 onmouseover="gutterOver(266)"

><td class="source">                System.Console.WriteLine(e);<br></td></tr
><tr
id=sl_svn11_267

 onmouseover="gutterOver(267)"

><td class="source">            }<br></td></tr
><tr
id=sl_svn11_268

 onmouseover="gutterOver(268)"

><td class="source"><br></td></tr
><tr
id=sl_svn11_269

 onmouseover="gutterOver(269)"

><td class="source">            System.Console.WriteLine(&quot;Print END&quot;);<br></td></tr
><tr
id=sl_svn11_270

 onmouseover="gutterOver(270)"

><td class="source">        }<br></td></tr
><tr
id=sl_svn11_271

 onmouseover="gutterOver(271)"

><td class="source">    }<br></td></tr
><tr
id=sl_svn11_272

 onmouseover="gutterOver(272)"

><td class="source">}<br></td></tr
></table></pre>
<pre><table width="100%"><tr class="cursor_stop cursor_hidden"><td></td></tr></table></pre>
</td>
</tr></table>

 
<script type="text/javascript">
 var lineNumUnderMouse = -1;
 
 function gutterOver(num) {
 gutterOut();
 var newTR = document.getElementById('gr_svn11_' + num);
 if (newTR) {
 newTR.className = 'undermouse';
 }
 lineNumUnderMouse = num;
 }
 function gutterOut() {
 if (lineNumUnderMouse != -1) {
 var oldTR = document.getElementById(
 'gr_svn11_' + lineNumUnderMouse);
 if (oldTR) {
 oldTR.className = '';
 }
 lineNumUnderMouse = -1;
 }
 }
 var numsGenState = {table_base_id: 'nums_table_'};
 var srcGenState = {table_base_id: 'src_table_'};
 var alignerRunning = false;
 var startOver = false;
 function setLineNumberHeights() {
 if (alignerRunning) {
 startOver = true;
 return;
 }
 numsGenState.chunk_id = 0;
 numsGenState.table = document.getElementById('nums_table_0');
 numsGenState.row_num = 0;
 if (!numsGenState.table) {
 return; // Silently exit if no file is present.
 }
 srcGenState.chunk_id = 0;
 srcGenState.table = document.getElementById('src_table_0');
 srcGenState.row_num = 0;
 alignerRunning = true;
 continueToSetLineNumberHeights();
 }
 function rowGenerator(genState) {
 if (genState.row_num < genState.table.rows.length) {
 var currentRow = genState.table.rows[genState.row_num];
 genState.row_num++;
 return currentRow;
 }
 var newTable = document.getElementById(
 genState.table_base_id + (genState.chunk_id + 1));
 if (newTable) {
 genState.chunk_id++;
 genState.row_num = 0;
 genState.table = newTable;
 return genState.table.rows[0];
 }
 return null;
 }
 var MAX_ROWS_PER_PASS = 1000;
 function continueToSetLineNumberHeights() {
 var rowsInThisPass = 0;
 var numRow = 1;
 var srcRow = 1;
 while (numRow && srcRow && rowsInThisPass < MAX_ROWS_PER_PASS) {
 numRow = rowGenerator(numsGenState);
 srcRow = rowGenerator(srcGenState);
 rowsInThisPass++;
 if (numRow && srcRow) {
 if (numRow.offsetHeight != srcRow.offsetHeight) {
 numRow.firstChild.style.height = srcRow.offsetHeight + 'px';
 }
 }
 }
 if (rowsInThisPass >= MAX_ROWS_PER_PASS) {
 setTimeout(continueToSetLineNumberHeights, 10);
 } else {
 alignerRunning = false;
 if (startOver) {
 startOver = false;
 setTimeout(setLineNumberHeights, 500);
 }
 }
 }
 function initLineNumberHeights() {
 // Do 2 complete passes, because there can be races
 // between this code and prettify.
 startOver = true;
 setTimeout(setLineNumberHeights, 250);
 window.onresize = setLineNumberHeights;
 }
 initLineNumberHeights();
</script>

 
 
 <div id="log">
 <div style="text-align:right">
 <a class="ifCollapse" href="#" onclick="_toggleMeta(this); return false">Show details</a>
 <a class="ifExpand" href="#" onclick="_toggleMeta(this); return false">Hide details</a>
 </div>
 <div class="ifExpand">
 
 
 <div class="pmeta_bubble_bg" style="border:1px solid white">
 <div class="round4"></div>
 <div class="round2"></div>
 <div class="round1"></div>
 <div class="box-inner">
 <div id="changelog">
 <p>Change log</p>
 <div>
 <a href="/p/kinect-shoulder/source/detail?spec=svn11&amp;r=9">r9</a>
 by bpapman@gmail.com
 on Oct 1, 2013
 &nbsp; <a href="/p/kinect-shoulder/source/diff?spec=svn11&r=9&amp;format=side&amp;path=/SQLiteDB.cs&amp;old_path=/SQLiteDB.cs&amp;old=8">Diff</a>
 </div>
 <pre>Updates that fixed everything</pre>
 </div>
 
 
 
 
 
 
 <script type="text/javascript">
 var detail_url = '/p/kinect-shoulder/source/detail?r=9&spec=svn11';
 var publish_url = '/p/kinect-shoulder/source/detail?r=9&spec=svn11#publish';
 // describe the paths of this revision in javascript.
 var changed_paths = [];
 var changed_urls = [];
 
 changed_paths.push('/SQLiteDB.cs');
 changed_urls.push('/p/kinect-shoulder/source/browse/SQLiteDB.cs?r\x3d9\x26spec\x3dsvn11');
 
 var selected_path = '/SQLiteDB.cs';
 
 
 function getCurrentPageIndex() {
 for (var i = 0; i < changed_paths.length; i++) {
 if (selected_path == changed_paths[i]) {
 return i;
 }
 }
 }
 function getNextPage() {
 var i = getCurrentPageIndex();
 if (i < changed_paths.length - 1) {
 return changed_urls[i + 1];
 }
 return null;
 }
 function getPreviousPage() {
 var i = getCurrentPageIndex();
 if (i > 0) {
 return changed_urls[i - 1];
 }
 return null;
 }
 function gotoNextPage() {
 var page = getNextPage();
 if (!page) {
 page = detail_url;
 }
 window.location = page;
 }
 function gotoPreviousPage() {
 var page = getPreviousPage();
 if (!page) {
 page = detail_url;
 }
 window.location = page;
 }
 function gotoDetailPage() {
 window.location = detail_url;
 }
 function gotoPublishPage() {
 window.location = publish_url;
 }
</script>

 
 <style type="text/css">
 #review_nav {
 border-top: 3px solid white;
 padding-top: 6px;
 margin-top: 1em;
 }
 #review_nav td {
 vertical-align: middle;
 }
 #review_nav select {
 margin: .5em 0;
 }
 </style>
 <div id="review_nav">
 <table><tr><td>Go to:&nbsp;</td><td>
 <select name="files_in_rev" onchange="window.location=this.value">
 
 <option value="/p/kinect-shoulder/source/browse/SQLiteDB.cs?r=9&amp;spec=svn11"
 selected="selected"
 >/SQLiteDB.cs</option>
 
 </select>
 </td></tr></table>
 
 
 <div id="review_instr" class="closed">
 <a class="ifOpened" href="/p/kinect-shoulder/source/detail?r=9&spec=svn11#publish">Publish your comments</a>
 <div class="ifClosed">Double click a line to add a comment</div>
 </div>
 
 </div>
 
 
 </div>
 <div class="round1"></div>
 <div class="round2"></div>
 <div class="round4"></div>
 </div>
 <div class="pmeta_bubble_bg" style="border:1px solid white">
 <div class="round4"></div>
 <div class="round2"></div>
 <div class="round1"></div>
 <div class="box-inner">
 <div id="older_bubble">
 <p>Older revisions</p>
 
 
 <div class="closed" style="margin-bottom:3px;" >
 <a class="ifClosed" onclick="return _toggleHidden(this)"><img src="https://ssl.gstatic.com/codesite/ph/images/plus.gif" ></a>
 <a class="ifOpened" onclick="return _toggleHidden(this)"><img src="https://ssl.gstatic.com/codesite/ph/images/minus.gif" ></a>
 <a href="/p/kinect-shoulder/source/detail?spec=svn11&r=8">r8</a>
 by bpapman@gmail.com
 on Oct 1, 2013
 &nbsp; <a href="/p/kinect-shoulder/source/diff?spec=svn11&r=8&amp;format=side&amp;path=/SQLiteDB.cs&amp;old_path=/SQLiteDB.cs&amp;old=3">Diff</a>
 <br>
 <pre class="ifOpened">Pushed more formatted data structs and
accesses</pre>
 </div>
 
 <div class="closed" style="margin-bottom:3px;" >
 <a class="ifClosed" onclick="return _toggleHidden(this)"><img src="https://ssl.gstatic.com/codesite/ph/images/plus.gif" ></a>
 <a class="ifOpened" onclick="return _toggleHidden(this)"><img src="https://ssl.gstatic.com/codesite/ph/images/minus.gif" ></a>
 <a href="/p/kinect-shoulder/source/detail?spec=svn11&r=3">r3</a>
 by bpapman@gmail.com
 on Sep 24, 2013
 &nbsp; <a href="/p/kinect-shoulder/source/diff?spec=svn11&r=3&amp;format=side&amp;path=/SQLiteDB.cs&amp;old_path=/SQLiteDB.cs&amp;old=">Diff</a>
 <br>
 <pre class="ifOpened">dur</pre>
 </div>
 
 
 <a href="/p/kinect-shoulder/source/list?path=/SQLiteDB.cs&start=9">All revisions of this file</a>
 </div>
 </div>
 <div class="round1"></div>
 <div class="round2"></div>
 <div class="round4"></div>
 </div>
 
 <div class="pmeta_bubble_bg" style="border:1px solid white">
 <div class="round4"></div>
 <div class="round2"></div>
 <div class="round1"></div>
 <div class="box-inner">
 <div id="fileinfo_bubble">
 <p>File info</p>
 
 <div>Size: 11391 bytes,
 272 lines</div>
 
 <div><a href="//kinect-shoulder.googlecode.com/svn/SQLiteDB.cs">View raw file</a></div>
 </div>
 
 </div>
 <div class="round1"></div>
 <div class="round2"></div>
 <div class="round4"></div>
 </div>
 </div>
 </div>


</div>

</div>
</div>

<script src="https://ssl.gstatic.com/codesite/ph/9670661675484913303/js/prettify/prettify.js"></script>
<script type="text/javascript">prettyPrint();</script>


<script src="https://ssl.gstatic.com/codesite/ph/9670661675484913303/js/source_file_scripts.js"></script>

 <script type="text/javascript" src="https://ssl.gstatic.com/codesite/ph/9670661675484913303/js/kibbles.js"></script>
 <script type="text/javascript">
 var lastStop = null;
 var initialized = false;
 
 function updateCursor(next, prev) {
 if (prev && prev.element) {
 prev.element.className = 'cursor_stop cursor_hidden';
 }
 if (next && next.element) {
 next.element.className = 'cursor_stop cursor';
 lastStop = next.index;
 }
 }
 
 function pubRevealed(data) {
 updateCursorForCell(data.cellId, 'cursor_stop cursor_hidden');
 if (initialized) {
 reloadCursors();
 }
 }
 
 function draftRevealed(data) {
 updateCursorForCell(data.cellId, 'cursor_stop cursor_hidden');
 if (initialized) {
 reloadCursors();
 }
 }
 
 function draftDestroyed(data) {
 updateCursorForCell(data.cellId, 'nocursor');
 if (initialized) {
 reloadCursors();
 }
 }
 function reloadCursors() {
 kibbles.skipper.reset();
 loadCursors();
 if (lastStop != null) {
 kibbles.skipper.setCurrentStop(lastStop);
 }
 }
 // possibly the simplest way to insert any newly added comments
 // is to update the class of the corresponding cursor row,
 // then refresh the entire list of rows.
 function updateCursorForCell(cellId, className) {
 var cell = document.getElementById(cellId);
 // we have to go two rows back to find the cursor location
 var row = getPreviousElement(cell.parentNode);
 row.className = className;
 }
 // returns the previous element, ignores text nodes.
 function getPreviousElement(e) {
 var element = e.previousSibling;
 if (element.nodeType == 3) {
 element = element.previousSibling;
 }
 if (element && element.tagName) {
 return element;
 }
 }
 function loadCursors() {
 // register our elements with skipper
 var elements = CR_getElements('*', 'cursor_stop');
 var len = elements.length;
 for (var i = 0; i < len; i++) {
 var element = elements[i]; 
 element.className = 'cursor_stop cursor_hidden';
 kibbles.skipper.append(element);
 }
 }
 function toggleComments() {
 CR_toggleCommentDisplay();
 reloadCursors();
 }
 function keysOnLoadHandler() {
 // setup skipper
 kibbles.skipper.addStopListener(
 kibbles.skipper.LISTENER_TYPE.PRE, updateCursor);
 // Set the 'offset' option to return the middle of the client area
 // an option can be a static value, or a callback
 kibbles.skipper.setOption('padding_top', 50);
 // Set the 'offset' option to return the middle of the client area
 // an option can be a static value, or a callback
 kibbles.skipper.setOption('padding_bottom', 100);
 // Register our keys
 kibbles.skipper.addFwdKey("n");
 kibbles.skipper.addRevKey("p");
 kibbles.keys.addKeyPressListener(
 'u', function() { window.location = detail_url; });
 kibbles.keys.addKeyPressListener(
 'r', function() { window.location = detail_url + '#publish'; });
 
 kibbles.keys.addKeyPressListener('j', gotoNextPage);
 kibbles.keys.addKeyPressListener('k', gotoPreviousPage);
 
 
 kibbles.keys.addKeyPressListener('h', toggleComments);
 
 }
 </script>
<script src="https://ssl.gstatic.com/codesite/ph/9670661675484913303/js/code_review_scripts.js"></script>
<script type="text/javascript">
 function showPublishInstructions() {
 var element = document.getElementById('review_instr');
 if (element) {
 element.className = 'opened';
 }
 }
 var codereviews;
 function revsOnLoadHandler() {
 // register our source container with the commenting code
 var paths = {'svn11': '/SQLiteDB.cs'}
 codereviews = CR_controller.setup(
 {"projectName":"kinect-shoulder","projectHomeUrl":"/p/kinect-shoulder","assetVersionPath":"https://ssl.gstatic.com/codesite/ph/9670661675484913303","loggedInUserEmail":"bpapman@gmail.com","relativeBaseUrl":"","token":"NhV3P9Nj0TmtL8O6LnXLpg5N3So:1381443204623","profileUrl":"/u/bpapman/","domainName":null,"assetHostPath":"https://ssl.gstatic.com/codesite/ph"}, '', 'svn11', paths,
 CR_BrowseIntegrationFactory);
 
 // register our source container with the commenting code
 // in this case we're registering the container and the revison
 // associated with the contianer which may be the primary revision
 // or may be a previous revision against which the primary revision
 // of the file is being compared.
 codereviews.registerSourceContainer(document.getElementById('lines'), 'svn11');
 
 codereviews.registerActivityListener(CR_ActivityType.REVEAL_DRAFT_PLATE, showPublishInstructions);
 
 codereviews.registerActivityListener(CR_ActivityType.REVEAL_PUB_PLATE, pubRevealed);
 codereviews.registerActivityListener(CR_ActivityType.REVEAL_DRAFT_PLATE, draftRevealed);
 codereviews.registerActivityListener(CR_ActivityType.DISCARD_DRAFT_COMMENT, draftDestroyed);
 
 
 
 
 
 
 
 var initialized = true;
 reloadCursors();
 }
 window.onload = function() {keysOnLoadHandler(); revsOnLoadHandler();};

</script>
<script type="text/javascript" src="https://ssl.gstatic.com/codesite/ph/9670661675484913303/js/dit_scripts.js"></script>

 
 
 
 <script type="text/javascript" src="https://ssl.gstatic.com/codesite/ph/9670661675484913303/js/ph_core.js"></script>
 
 
 
 
</div> 

<div id="footer" dir="ltr">
 <div class="text">
 <a href="/projecthosting/terms.html">Terms</a> -
 <a href="http://www.google.com/privacy.html">Privacy</a> -
 <a href="/p/support/">Project Hosting Help</a>
 </div>
</div>
 <div class="hostedBy" style="margin-top: -20px;">
 <span style="vertical-align: top;">Powered by <a href="http://code.google.com/projecthosting/">Google Project Hosting</a></span>
 </div>

 
 


 
 </body>
</html>

