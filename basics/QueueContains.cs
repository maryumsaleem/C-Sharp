<!DOCTYPE html>
<!-- saved from url=(0057)https://www.tutorialsteacher.com/codeeditor?cid=cs-QiuASA -->
<html class=" no-htmlimports no-flash no-proximity apng webpanimation no-dataworkers no-blobworkers videoautoplay audiopreload indexeddb indexeddb-deletedatabase"><head><meta http-equiv="Content-Type" content="text/html; charset=UTF-8"><script async="" type="text/javascript" src="./QueueContains_files/gpt.js.download"></script><script async="" type="text/javascript" src="./QueueContains_files/tc-modernizr.js.download"></script><script async="" type="text/javascript" src="./QueueContains_files/gfc.js.download"></script><script async="" type="text/javascript" src="./QueueContains_files/pg-220525-27a-nc-3988e75414e437db85119b9c58fd766a.js.download"></script>
    <link rel="dns-prefetch" href="https://a3.pubguru.net/"><link rel="preconnect" href="https://a3.pubguru.net/" crossorigin="">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="./QueueContains_files/pPXHlLb1CGI6YEB-9-_z05e8AO8.js.download"></script><script src="./QueueContains_files/tPAjUEoy7r1Z4pKD3wERlshlDH0.js.download"></script><link rel="canonical" href="https://www.tutorialsteacher.com/codeeditor">
    <title>Code Editor</title>
    <link type="text/css" href="./QueueContains_files/bootstrap.min.css" rel="stylesheet">
    <!--[if lt IE 9]>
          <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
    <link href="./QueueContains_files/tryit.min.css" rel="stylesheet">
    <link href="./QueueContains_files/codemirror.css" rel="stylesheet">
    
    <script src="./QueueContains_files/pghb.tutorialsteacher.com.js.download" async=""></script>
<link rel="stylesheet" href="data:text/css;charset=utf-8;base64,Y2xvdWRmbGFyZS1hcHBbYXBwLWlkPSJhLWJldHRlci1icm93c2VyIl0gewogIGRpc3BsYXk6IGJsb2NrOwogIGJhY2tncm91bmQ6ICM0NTQ4NGQ7CiAgY29sb3I6ICNmZmY7CiAgbGluZS1oZWlnaHQ6IDEuNDU7CiAgcG9zaXRpb246IGZpeGVkOwogIHotaW5kZXg6IDkwMDAwMDAwOwogIHRvcDogMDsKICBsZWZ0OiAwOwogIHJpZ2h0OiAwOwogIHBhZGRpbmc6IC41ZW0gMWVtOwogIHRleHQtYWxpZ246IGNlbnRlcjsKICAtd2Via2l0LXVzZXItc2VsZWN0OiBub25lOwogICAgIC1tb3otdXNlci1zZWxlY3Q6IG5vbmU7CiAgICAgIC1tcy11c2VyLXNlbGVjdDogbm9uZTsKICAgICAgICAgIHVzZXItc2VsZWN0OiBub25lOwp9CgpjbG91ZGZsYXJlLWFwcFthcHAtaWQ9ImEtYmV0dGVyLWJyb3dzZXIiXVtkYXRhLXZpc2liaWxpdHk9ImhpZGRlbiJdIHsKICBkaXNwbGF5OiBub25lOwp9CgpjbG91ZGZsYXJlLWFwcFthcHAtaWQ9ImEtYmV0dGVyLWJyb3dzZXIiXSBjbG91ZGZsYXJlLWFwcC1tZXNzYWdlIHsKICBkaXNwbGF5OiBibG9jazsKfQoKY2xvdWRmbGFyZS1hcHBbYXBwLWlkPSJhLWJldHRlci1icm93c2VyIl0gYSB7CiAgdGV4dC1kZWNvcmF0aW9uOiB1bmRlcmxpbmU7CiAgY29sb3I6ICNlYmViZjQ7Cn0KCmNsb3VkZmxhcmUtYXBwW2FwcC1pZD0iYS1iZXR0ZXItYnJvd3NlciJdIGE6aG92ZXIsCmNsb3VkZmxhcmUtYXBwW2FwcC1pZD0iYS1iZXR0ZXItYnJvd3NlciJdIGE6YWN0aXZlIHsKICBjb2xvcjogI2RiZGJlYjsKfQoKY2xvdWRmbGFyZS1hcHBbYXBwLWlkPSJhLWJldHRlci1icm93c2VyIl0gY2xvdWRmbGFyZS1hcHAtY2xvc2UgewogIGRpc3BsYXk6IGJsb2NrOwogIGN1cnNvcjogcG9pbnRlcjsKICBmb250LXNpemU6IDEuNWVtOwogIHBvc2l0aW9uOiBhYnNvbHV0ZTsKICByaWdodDogLjRlbTsKICB0b3A6IC4zNWVtOwogIGhlaWdodDogMWVtOwogIHdpZHRoOiAxZW07CiAgbGluZS1oZWlnaHQ6IDE7Cn0KCmNsb3VkZmxhcmUtYXBwW2FwcC1pZD0iYS1iZXR0ZXItYnJvd3NlciJdIGNsb3VkZmxhcmUtYXBwLWNsb3NlOmFjdGl2ZSB7CiAgLXdlYmtpdC10cmFuc2Zvcm06IHRyYW5zbGF0ZVkoMXB4KTsKICAgICAgICAgIHRyYW5zZm9ybTogdHJhbnNsYXRlWSgxcHgpOwp9CgpjbG91ZGZsYXJlLWFwcFthcHAtaWQ9ImEtYmV0dGVyLWJyb3dzZXIiXSBjbG91ZGZsYXJlLWFwcC1jbG9zZTpob3ZlciB7CiAgb3BhY2l0eTogLjllbTsKICBjb2xvcjogI2ZmZjsKfQo="><script async="" src="./QueueContains_files/AGSKWxVfaWDm5RiIXURyia8Dx4Ew7qXVwt2Pcv7BENtuRvg5lpgnI5YgMqPGC6Y8B_fs_ecOmqm1tKP9veCMBvwzsBg="></script><script async="" src="./QueueContains_files/AGSKWxVzYZ8qiztRKaY_nRlXgSyP4ArSqLOQ3vXlkTBe4lOr7zqQGw9eMNy4qtCYkk-14Hm9IEWOqgnBgoIyBdfSndA="></script><meta http-equiv="origin-trial" content="AzoawhTRDevLR66Y6MROu167EDncFPBvcKOaQispTo9ouEt5LvcBjnRFqiAByRT+2cDHG1Yj4dXwpLeIhc98/gIAAACFeyJvcmlnaW4iOiJodHRwczovL2RvdWJsZWNsaWNrLm5ldDo0NDMiLCJmZWF0dXJlIjoiUHJpdmFjeVNhbmRib3hBZHNBUElzIiwiZXhwaXJ5IjoxNjYxMjk5MTk5LCJpc1N1YmRvbWFpbiI6dHJ1ZSwiaXNUaGlyZFBhcnR5Ijp0cnVlfQ=="><meta http-equiv="origin-trial" content="A6+nc62kbJgC46ypOwRsNW6RkDn2x7tgRh0wp7jb3DtFF7oEhu1hhm4rdZHZ6zXvnKZLlYcBlQUImC4d3kKihAcAAACLeyJvcmlnaW4iOiJodHRwczovL2dvb2dsZXN5bmRpY2F0aW9uLmNvbTo0NDMiLCJmZWF0dXJlIjoiUHJpdmFjeVNhbmRib3hBZHNBUElzIiwiZXhwaXJ5IjoxNjYxMjk5MTk5LCJpc1N1YmRvbWFpbiI6dHJ1ZSwiaXNUaGlyZFBhcnR5Ijp0cnVlfQ=="><meta http-equiv="origin-trial" content="A/9La288e7MDEU2ifusFnMg1C2Ij6uoa/Z/ylwJIXSsWfK37oESIPbxbt4IU86OGqDEPnNVruUiMjfKo65H/CQwAAACLeyJvcmlnaW4iOiJodHRwczovL2dvb2dsZXRhZ3NlcnZpY2VzLmNvbTo0NDMiLCJmZWF0dXJlIjoiUHJpdmFjeVNhbmRib3hBZHNBUElzIiwiZXhwaXJ5IjoxNjYxMjk5MTk5LCJpc1N1YmRvbWFpbiI6dHJ1ZSwiaXNUaGlyZFBhcnR5Ijp0cnVlfQ=="><script src="./QueueContains_files/pubads_impl_2022060901.js.download" async=""></script><link rel="preload" href="./QueueContains_files/f.txt" as="script"><script type="text/javascript" src="./QueueContains_files/f.txt"></script><link rel="preload" href="./QueueContains_files/f(1).txt" as="script"><script type="text/javascript" src="./QueueContains_files/f(1).txt"></script><script async="" src="./QueueContains_files/AGSKWxUU4dcshmO5Wa5klJdoSAGA4Sg13IacXjT6Wcu3BYPEnOzSh6im8llXDCWJDkSiG_v8HIMtnT0rHbFB4gA69cBcEurTKbADXLxLOGWJJHuyftmn5PMubmeOPZQI3Tas2OHfG96yi8e7Nasly8LkRLjKcZN1a2V7GTxwwQ6bpiHC-UHo2v0arZR_24Td"></script><script async="" src="./QueueContains_files/AGSKWxV7j4iyN6zzHwCvnyn3qlLr6n1_DrAe_RwWISa-JYnVcTuNML4b7MonEVSEROlFMaPXXuT_GYG3fDgaH8WHQoINxbNwx_EztXlTEPW92ENMM0hmDh5s-NcbRMhrc0gX2-QKvvPouLi7aUrHX9TpNCFTodv9cCsCij1ON_eiqTqPAhJYv3PmZoQM-9PU"></script><script async="" src="./QueueContains_files/AGSKWxWAO5ZlpggHeEve6_y4z4-BLMWph73LR41GLuCGfW9_iEFeR7kaVJiNavw5feLIAPi2dYfsV8ZD_E9OdikIhxjcz2gsrL6u3-aOa5nY9tP4P6CU4EMmQikJp7ISIDN-3TNvjTNr4iWITDoKiQtkzacigcKTixR1AeQtD6DMT3xP2Cd2DnWUx2bU2fAe"></script></head>
<body class="" data-new-gr-c-s-check-loaded="14.1063.0" data-gr-ext-installed="" data-new-gr-c-s-loaded="14.1063.0"><div id="color-overlay__extension-mask" style="width: 100%; height: 100%; position: fixed; inset: 0px; pointer-events: none; z-index: 2147483647;"></div>
    <div class="container-fluid">
        <div id="header" class="row header">
            <div class="col-lg-12 col-xs-12">
                <h1>&lt;code&gt; Editor</h1>
                <div class="ad_div" style="">
                    <div id="tt_leaderboard_atf_desk" class="pg-loaded"><div id="google_ads_iframe_/73863230/tt_leaderboard_atf_desk_0__container__" style="border: 0pt none; width: 728px; height: 0px;"></div></div>
                </div>
            </div>
        </div>
        <div id="main">
                <iframe id="dotnetiframe" class="dotnetfiddleIframe" src="./QueueContains_files/QiuASA.html" frameborder="0"></iframe>
        </div>

        <div class="row ">
            <div class="col-xs-12 footer">Copyright © 2022 by tutorialsteacher. All Rights Reserved. </div>
        </div>
    </div>
    <script src="./QueueContains_files/jquery.min.js.download"></script>
    <script src="./QueueContains_files/popper.min.js.download"></script>
    <script src="./QueueContains_files/bootstrap.min.js.download"></script>
    <script src="./QueueContains_files/cejs"></script>

    <script>
        $(document).ready(function () {
            var codeTextArea = $('#CodeString')[0];
            if (codeTextArea) {
                var myc = CodeMirror.fromTextArea(codeTextArea,
                    {
                        mode: "htmlmixed",
                        lineNumbers: true,
                        selectionPointer: true,
                        styleActiveLine: true
                    });
            }
        });
        function validateForm() {
            var code = codeTextArea.value;
            if (code.length > 5000) {
                alert('Lengthy code is not allowd. Please reduce the code size.')
                return false;
            }
        };
    </script>


<div id="torrent-scanner-popup" style="display: none;"></div><div style="display: none;"><a title="Do not click me1!" id="hp1" href="https://www.tutorialsteacher.com/codeeditor?cid=cs-QiuASA#">&lt;!â€“- Don't click me1 â€“-&gt;</a></div><a id="hp2" title="Don&#39;t click!" href="https://www.tutorialsteacher.com/codeeditor?cid=cs-QiuASA#" style="display: none;"><img src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mNkYPhfDwAChwGA60e6kgAAAABJRU5ErkJggg==" style="width:1px !important;height:1px !important;"></a><iframe name="googlefcPresent" style="display: none; width: 0px; height: 0px; border: none; z-index: -1000; left: -1000px; top: -1000px;" src="./QueueContains_files/saved_resource.html"></iframe><iframe name="__tcfapiLocator" src="./QueueContains_files/saved_resource(1).html" style="display: none; width: 0px; height: 0px; border: none; z-index: -1000; left: -1000px; top: -1000px;"></iframe><iframe name="__uspapiLocator" src="./QueueContains_files/saved_resource(2).html" style="display: none; width: 0px; height: 0px; border: none; z-index: -1000; left: -1000px; top: -1000px;"></iframe><iframe name="googlefcInactive" src="./QueueContains_files/saved_resource(3).html" style="display: none; width: 0px; height: 0px; border: none; z-index: -1000; left: -1000px; top: -1000px;"></iframe><iframe name="googlefcLoaded" src="./QueueContains_files/saved_resource(4).html" style="display: none; width: 0px; height: 0px; border: none; z-index: -1000; left: -1000px; top: -1000px;"></iframe><iframe src="./QueueContains_files/aframe.html" width="0" height="0" style="display: none;"></iframe></body><grammarly-desktop-integration data-grammarly-shadow-root="true"></grammarly-desktop-integration><iframe sandbox="allow-scripts allow-same-origin" id="9252a5480262c45" frameborder="0" allowtransparency="true" marginheight="0" marginwidth="0" width="0" hspace="0" vspace="0" height="0" style="height:0px;width:0px;display:none;" scrolling="no" src="./QueueContains_files/pd.html">
    </iframe><iframe sandbox="allow-scripts allow-same-origin" id="93713d5829cb63f" frameborder="0" allowtransparency="true" marginheight="0" marginwidth="0" width="0" hspace="0" vspace="0" height="0" style="height:0px;width:0px;display:none;" scrolling="no" src="./QueueContains_files/ixmatch.html">
    </iframe><iframe sandbox="allow-scripts allow-same-origin" id="94cbb607d05c0c5" frameborder="0" allowtransparency="true" marginheight="0" marginwidth="0" width="0" hspace="0" vspace="0" height="0" style="height:0px;width:0px;display:none;" scrolling="no" src="./QueueContains_files/user_sync.html">
    </iframe><iframe sandbox="allow-scripts allow-same-origin" id="95b660d619d7a92" frameborder="0" allowtransparency="true" marginheight="0" marginwidth="0" width="0" hspace="0" vspace="0" height="0" style="height:0px;width:0px;display:none;" scrolling="no" src="./QueueContains_files/async_usersync.html">
    </iframe></html>