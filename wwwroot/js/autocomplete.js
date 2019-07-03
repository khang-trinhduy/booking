function autocomplete(inp, arr) {
  /*the autocomplete function takes two arguments,
  the text field element and an array of possible autocompleted values:*/
  var currentFocus;
  /*execute a function when someone writes in the text field:*/
  inp.addEventListener("input", function (e) {
    var a, b, i, val = this.value;
    /*close any already open lists of autocompleted values*/
    closeAllLists();
    if (!val) {
      return false;
    }
    currentFocus = -1;
    /*create a DIV element that will contain the items (values):*/
    a = document.createElement("DIV");
    a.setAttribute("id", this.id + "autocomplete-list");
    a.setAttribute("class", "autocomplete-items");
    /*append the DIV element as a child of the autocomplete container:*/
    this.parentNode.appendChild(a);
    /*for each item in the array...*/
    for (i = 0; i < arr.length; i++) {
      var str = '';
      var matched = true;
      var matchIndex = -1;
      var itemName = arr[i];
      //loop through arr to get each name
      //loop through each name to get each char
      //loop through val to get chars
      //if char match the name then highlight it
      //must be in order
      //return new name
      //append to element
      //current index = length str 
      for (let j = 0; j < val.length; j++) {
        const char = val[j].toUpperCase();
        var subName = itemName.substring(matchIndex + 1, itemName.length);
        if (subName.indexOf(char) > -1) {
          matchIndex = subName.indexOf(char);
          var preMatch = subName.substring(0, subName.indexOf(matchIndex));
          console.log(subName);
          var matched = "<strong>" + itemName[matchIndex] + "</strong>";
          str += preMatch + matched;
          matchIndex += preMatch.length + 1;
        } else {
          matched = false;
          continue;
        }
      }
      if (matched) {
        if (matchIndex < arr[i].length) {
          str += arr[i].substring(matchIndex + 1, arr[i].length);
        }
        b = createItems(b, str, i);
        a.appendChild(b);

      } else {
        continue;

      }
      ({ str, matched, matchIndex } = reinitialize(str, matched, matchIndex));
    }


  });

  function reinitialize(str, matched, matchIndex) {
    str = '';
    matched = true;
    matchIndex = -1;
    return { str, matched, matchIndex };
  }

  function createItems(b, str, i) {
    b = document.createElement("DIV");
    b.innerHTML += str;
    b.innerHTML += "<input type='hidden' value='" + arr[i] + "'>";
    /*execute a function when someone clicks on the item value (DIV element):*/
    b.addEventListener("click", function (e) {
      /*insert the value for the autocomplete text field:*/
      inp.value = this.getElementsByTagName("input")[0].value;
      /*close the list of autocompleted values,
      (or any other open lists of autocompleted values:*/
      closeAllLists();
    });
    return b;
  }
/*execute a function presses a key on the keyboard:*/
inp.addEventListener("keydown", function (e) {
  var x = document.getElementById(this.id + "autocomplete-list");
  if (x) x = x.getElementsByTagName("div");
  if (e.keyCode == 40) {
    /*If the arrow DOWN key is pressed,
    increase the currentFocus variable:*/
    currentFocus++;
    /*and and make the current item more visible:*/
    addActive(x);
  } else if (e.keyCode == 38) { //up
    /*If the arrow UP key is pressed,
    decrease the currentFocus variable:*/
    currentFocus--;
    /*and and make the current item more visible:*/
    addActive(x);
  } else if (e.keyCode == 13) {
    /*If the ENTER key is pressed, prevent the form from being submitted,*/
    e.preventDefault();
    if (currentFocus > -1) {
      /*and simulate a click on the "active" item:*/
      if (x) x[currentFocus].click();
    }
  }
});

function addActive(x) {
  /*a function to classify an item as "active":*/
  if (!x) return false;
  /*start by removing the "active" class on all items:*/
  removeActive(x);
  if (currentFocus >= x.length) currentFocus = 0;
  if (currentFocus < 0) currentFocus = (x.length - 1);
  /*add class "autocomplete-active":*/
  x[currentFocus].classList.add("autocomplete-active");
}

function removeActive(x) {
  /*a function to remove the "active" class from all autocomplete items:*/
  for (var i = 0; i < x.length; i++) {
    x[i].classList.remove("autocomplete-active");
  }
}

function closeAllLists(elmnt) {
  /*close all autocomplete lists in the document,
  except the one passed as an argument:*/
  var x = document.getElementsByClassName("autocomplete-items");
  for (var i = 0; i < x.length; i++) {
    if (elmnt != x[i] && elmnt != inp) {
      x[i].parentNode.removeChild(x[i]);
    }
  }
}
/*execute a function when someone clicks in the document:*/
document.addEventListener("click", function (e) {
  closeAllLists(e.target);
});
}