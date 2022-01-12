"use strict";

let Main = function () {
  let c = prompt("Entrez un caractère : ");
  let voyelle = ContientVoyelle(c);
  console.log(voyelle);
};

function ContientVoyelle(c) {
  let voyelles = ["a", "e", "i", "o", "u", "y"];
  for (let i = 0; i < voyelles.length; i++) {
    if (voyelles[i] == c) {
      return true;
    }
  }
  return false;
}

window.onload = Main();
