"use strict";

let Main = function () {
  let myTab = InitTab();

  let maximum = FindMax(myTab);

  let s = `${maximum.X} => ${maximum.Y}`;
  console.log(s);

  console.log(`max : ${maximum.X} à la position : ${maximum.Y}`);
};

function InitTab() {
  let array1 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
  array1[12] = 800;
  return array1;
}

function FindMax(tab) {
  let i;
  let max = tab[0];
  let maxPos = 0;

  for (i = 1; i < tab.length; i++) {
    if (tab[i] > max) {
      max = tab[i];
      maxPos = i;
    }
  }
  let maximum = { X: max, Y: maxPos };
  return maximum;
}

window.onload = Main();
