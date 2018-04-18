
function playMe(me) {
        toggleLoadingControls(true);
        console.log("me:", me);
        document.getElementById("player_title").innerHTML = me.parentNode.textContent.substring(10,me.parentNode.textContent.length);

        var x = document.getElementById("player");        
        x.setAttribute('data-id', me.id);
        x.setAttribute("src", me.getAttribute("playurl"));
        x.play();
}

    // 控制播放器的显示与隐藏
    function toggleLoadingControls(loading) {
        if (loading) {
            document.querySelector('#swtyChinaPlayer').setAttribute('class', "navbar navbar-default navbar-fixed-bottom mccPlayerbackground");
        }
        else {
            document.querySelector('#swtyChinaPlayer').setAttribute('class', "navbar navbar-default navbar-fixed-bottom mccPlayerbackground hidden");
        }
    }


    $(document).ready(function () {
        console.log("ready:");  

        //$(".list_menu__icon_play").click(function () {
        //    console.log("#playItem:click()");
        //    $("#swtyChinaPlayer").attr("class", "navbar navbar-default navbar-fixed-bottom mccPlayerbackground");
        //});

        player.onended = function () {
            var id = player.getAttribute('data-id');
            if (id == 10) {
                id = 1;
            }
            else {
                id++;
            }
                                   
            var next = document.getElementById(id);
            setTimeout(function () {
                if (next)
                    next.click();
            }, 1000);
        };
        player.onerror = function () {
            document.getElementById("player_title").textContent += " (无法播放！)";
        };

        $("[data-toggle='popover']").popover({
            trigger: 'hover',
           
        });

       
    });