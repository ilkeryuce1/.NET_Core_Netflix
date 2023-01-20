function getInputValueandText(textId, changedtextId) {
    var degistiren = document.getElementById(textId);
    var degisen = document.getElementById(changedtextId);
    degisen.innerHTML = degistiren.value;
    degisen.style.border = "3px solid white";
    degisen.style.borderRadius = "3px";
    degisen.style.transition = "0.5s";
}
function getText(textId, changedtextId) {
    var degistiren = document.getElementById(textId);
    var degisen = document.getElementById(changedtextId);
    degisen.innerHTML = degistiren.options[degistiren.selectedIndex].text;
    degisen.style.fontSize = "19px";
    degisen.style.border = "3px solid white";
    degisen.style.borderRadius = "3px";
    degisen.style.transition = "0.5s";
}
function borderRemove(id) {
    var column = document.getElementById(id);
    column.style.border = "none";
}
function reverse(class1, class2) {
    var front = document.getElementById(class1);
    var back = document.getElementById(class2);
    front.style.transform = "rotateY(180deg)";
    front.style.opacity = "0";
    back.style.transform = "rotateY(360deg)"
    back.style.opacity = "1";
}
function reverseback(class1, class2) {
    var front = document.getElementById(class1);
    var back = document.getElementById(class2);
    front.style.transform = "rotateY(0deg)";
    front.style.opacity = "1";
    back.style.transform = "rotateY(180deg)"
    back.style.opacity = "0";
}
var keysRows = document.getElementsByClassName("keys");
for (var i = 0; i < keysRows.length; i++) {
    var keysRow = keysRows[i];
    for (var j = 0; j < 4; j++) {
        var span = document.createElement("span");
        if (i % 2 == 0) {
            span.innerHTML = "#";
            span.style.opacity = "1";
            keysRow.appendChild(span);
        }
        else if (i % 2 == 1) {
            span.innerHTML = "*";
            span.style.opacity = "0";
            keysRow.appendChild(span);
        }
    }
}
var i = 1;
var j = 0;
function modify() {
    var degistiren = document.getElementById("cdnumber");
    var keysRows = document.getElementsByClassName("keys");
    if (i <= 4) {
        var keysRowFront = keysRows[0];
        var keysRowBack = keysRows[1];
        var frontText = keysRowFront.children;
        var backText = keysRowBack.children;
        keysRowBack.style.border = "1px solid white";
        keysRowBack.style.borderRadius = "3px";
        keysRowBack.style.transition = "0.5s";
        frontText[j].style.opacity = "0";
        frontText[j].style.transform = "translateY(-15px)";
        backText[j].style.opacity = "1";
        backText[j].style.transitionDelay = "0.2s";
        backText[j].innerHTML = String(degistiren.value).slice(-1);
        if (i == 4) {
            j = 0;
            keysRowBack.style.border = "none";
        }
        else {
            j++;
        }
        i++;
    }
    else if (i <= 8) {
        var keysRowFront = keysRows[2];
        var keysRowBack = keysRows[3];
        var frontText = keysRowFront.children;
        var backText = keysRowBack.children;
        keysRowBack.style.border = "1px solid white";
        keysRowBack.style.borderRadius = "3px";
        keysRowBack.style.transition = "0.5s";
        frontText[j].style.opacity = "0";
        frontText[j].style.transform = "translateY(-15px)";
        backText[j].style.opacity = "1";
        backText[j].style.transitionDelay = "0.2s";
        if (i == 8) {
            j = 0;
            keysRowBack.style.border = "none";
        }
        else {
            j++;
        }
        i++;
    }
    else if (i <= 12) {
        var keysRowFront = keysRows[4];
        var keysRowBack = keysRows[5];
        var frontText = keysRowFront.children;
        var backText = keysRowBack.children;
        keysRowBack.style.border = "1px solid white";
        keysRowBack.style.borderRadius = "3px";
        keysRowBack.style.transition = "0.5s";
        frontText[j].style.opacity = "0";
        frontText[j].style.transform = "translateY(-15px)";
        backText[j].style.opacity = "1";
        backText[j].style.transitionDelay = "0.2s";
        if (i == 12) {
            j = 0;
            keysRowBack.style.border = "none";
        }
        else {
            j++;
        }
        i++;
    }
    else if (i <= 16) {
        var keysRowFront = keysRows[6];
        var keysRowBack = keysRows[7];
        var frontText = keysRowFront.children;
        var backText = keysRowBack.children;
        keysRowBack.style.border = "1px solid white";
        keysRowBack.style.borderRadius = "3px";
        keysRowBack.style.transition = "0.5s";
        frontText[j].style.opacity = "0";
        frontText[j].style.transform = "translateY(-15px)";
        backText[j].style.opacity = "1";
        backText[j].style.transitionDelay = "0.2s";
        backText[j].innerHTML = String(degistiren.value).slice(-1);
        if (i == 16) {
            j = 0;
            keysRowBack.style.border = "none";
        }
        else {
            j++;
        }
        i++;
    }
}