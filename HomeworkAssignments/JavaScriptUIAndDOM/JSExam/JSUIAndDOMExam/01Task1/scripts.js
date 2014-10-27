function createImagesPreviewer(selector, items) {

    // Select elements
    var container = document.querySelector(selector);
    var leftContainer = document.createElement('div');
    var rightContainer = document.createElement('div');
    var defaultBackgroundColour = container.style.background;

    // Add classes
    leftContainer.classList.add('left');
    rightContainer.classList.add('right');

    // Set styles
    leftContainer.style.display = 'inline-block';
    rightContainer.style.display = 'inline-block';
    leftContainer.style.padding = '5%';
    rightContainer.style.overflowY = 'scroll';
    rightContainer.style.height = '600px';

    // Create initial elements
    var header = document.createElement('h1');
    var headerRight = document.createElement('h4');
    var picture = document.createElement('img');

    // Left image container
    var mainHeader = header.cloneNode(true);
    var mainPicture = picture.cloneNode(true);
    mainPicture.src = items[0].url;
    mainPicture.style.borderRadius = '15px';
    picture.style.borderRadius = '5px';
    mainPicture.style.width = '600px';
    mainHeader.style.textAlign = 'center';

    mainHeader.innerText = items[0].title;
    mainHeader.textContent = items[0].title;
    mainPicture.classList.add('main-picture');

    leftContainer.appendChild(mainHeader);
    leftContainer.appendChild(mainPicture);

    // Right image container
    // Filter search input
    var label = document.createElement('p');
    var textBox = document.createElement('input');
    var filterContains;
    var currentInput;
    label.innerText = 'Filter';
    label.textContent = 'Filter';
    label.style.textAlign = 'center';
    textBox.setAttribute('type', 'text');

    textBox.addEventListener('keyup', function () {
        currentInput = this.value.toLowerCase();

        filterContains = container.getElementsByClassName('preview');

        for (var i = 0; i < items.length; i++) {
            filterContains[i].style.display = 'none';

            if (items[i].title.toLowerCase().contains(currentInput)) {
                filterContains[i].style.display = 'block';
            }
        }
    });

    rightContainer.appendChild(label);
    rightContainer.appendChild(textBox);

    // Preview pictures
    var rightHeader;
    var rightPicture;
    var div = document.createElement('div');
    var rightPictureDiv;
    var onClickContainer;
    var onClickPicture;

    for (var i = 0; i < items.length; i += 1) {
        rightHeader = headerRight.cloneNode(true);
        rightPicture = picture.cloneNode(true);
        rightHeader.textContent = items[i].title;
        rightHeader.style.textAlign = 'center';
        rightPicture.src = items[i].url;
        rightPicture.style.width = '150px';
        rightPictureDiv = div.cloneNode(true);
        rightPictureDiv.appendChild(rightHeader);
        rightPictureDiv.appendChild(rightPicture);
        rightPictureDiv.classList.add('preview');
        rightPictureDiv.addEventListener('mouseenter', function () {
            this.style.background = '#CCC';
        });
        rightPictureDiv.addEventListener('mouseleave', function () {
            this.style.background = defaultBackgroundColour || '#FFF';
        });
        rightPictureDiv.addEventListener('click', function () {
            onClickContainer = container.getElementsByClassName('left');
            onClickPicture = container.getElementsByClassName('main-picture');

            onClickContainer[0].childNodes[0].textContent = this.childNodes[0].textContent;
            onClickContainer[0].childNodes[1].src = this.childNodes[1].src;
        });

        rightContainer.appendChild(rightPictureDiv);
    }

    container.appendChild(leftContainer);
    container.appendChild(rightContainer);
}