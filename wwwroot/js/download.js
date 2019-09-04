let rad3 = document.querySelector('#three');

let rad5 = document.querySelector('#five');

let rad10 = document.querySelector('#ten');

let firstFile = document.querySelector('#firstFile');

function radChangeValue(e) {

    let firstFileIndex = parseInt(firstFile.value);

    let numberOfFiles = parseInt(e.srcElement.value);

    let lastFile = document.querySelector('#lastFile');

    lastFile.value = firstFileIndex + numberOfFiles;
    return;
}

function onChange(e) {
    let firstIndex = parseInt(e.target.value);

    let numberOfFiles = parseInt(rad3.checked ? 3 : rad5.checked ? 5 : 10);

    let lastFile = document.querySelector('#lastFile');

    lastFile.value = firstIndex + numberOfFiles;
    return;
}

rad3.addEventListener('change', radChangeValue);
rad5.addEventListener('change', radChangeValue);
rad10.addEventListener('change', radChangeValue);

firstFile.addEventListener('input', onChange);

let submit = document.querySelector('#multiple');

function onSubmit(e) {
    e.preventDefault();
    let from = document.querySelector('#firstFile').value;
    let to = document.querySelector('#lastFile').value;
    let code = window.location.search.slice(6);

    let url = $(this).attr('href');
    url = url.replace('fromFile', from);
    url = url.replace('toFile', to);
    url = url.replace('dlwc', code);
    window.location.href = url;
}

submit.addEventListener('click', onSubmit);