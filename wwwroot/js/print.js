let slider = document.getElementById('Quantity');
if (slider === null || slider === undefined) {
    console.log('Cannot read slider!');
}

let tracker = document.getElementById('tracker');

if (tracker === null || tracker === undefined) {
    console.log('Cannot read tracker!');
}

var onSliderChange = function() {
    let trackerContent = 'Số lượng files cần in: ';
    let currentSliderValue = slider.value;

    if (currentSliderValue === '' || currentSliderValue === null || currentSliderValue === undefined) {
        console.log('Cannot get slider value');
    }

    trackerContent += currentSliderValue;

    tracker.textContent = trackerContent;
}

slider.addEventListener('input', onSliderChange);

tracker.textContent = 'Số lượng files cần in: ' + slider.value;