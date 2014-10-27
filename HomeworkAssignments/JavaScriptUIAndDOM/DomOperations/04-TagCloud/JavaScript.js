function generateGoupedList(arr) {
    arr = arr.sort();
    var len = arr.length;
    var count = 1;
    var groupedArr = [];
    var currentTag = arr[0];

    for (var i = 1; i < len; i++) {
        if (arr[i] != currentTag) {
            groupedArr.push({ name: currentTag, count: count });
            currentTag = arr[i];
            count = 1;
        } else {
            count++;
        }
    }
    groupedArr.push({ name: currentTag, count: count });     
    groupedArr = groupedArr.sort(function (a, b) { return a.count - b.count; });

    console.log(groupedArr);
    return groupedArr;
}

function main() {
    var tags = ["cms", "javascript", "js",
   "ASP.NET MVC", ".net", ".net", "css",
   "wordpress", "xaml", "js", "http", "web",
   "asp.net", "asp.net MVC", "ASP.NET MVC",
   "wp", "javascript", "js", "cms", "html",
   "javascript", "http", "http", "CMS"];
    
    toLower(tags);
    var tagCloud = generateGoupedList(tags);
    generateTagCloud(tagCloud, 17, 42);
}

function toLower(arr) {
    var len = arr.length;
    for (var i = 0; i < len; i++) {
        arr[i] = arr[i].toLowerCase();
    }

    //return arr;
}

function generateTagCloud(tags, min, max) {
    var fontSizeStep = countOfDiferentSizeElements(tags) - 1;
    var len = tags.length;

    var docFragment = document.createDocumentFragment();
    var strong = document.createElement("strong");
    strong.style.display = "block";
    strong.style.position = "absolute";
    var elementCount = 0;
    var curCount = tags[0].count;

    for (var i = 0; i < len; i++) {
        strong = strong.cloneNode(true);
        strong.textContent = tags[i].name;
        strong.style.fontSize = (min + (tags[i].count + (elementCount * (Math.floor(getFontScale(min, max) / fontSizeStep))))) + "px";
        strong.style.left = generateRandomNumber(20, 500) + "px";
        strong.style.top = generateRandomNumber(20, 500) + "px";

        docFragment.appendChild(strong);

        if (curCount != tags[i].count) {
            curCount = tags[i].count;
            elementCount++;
        }
    }
    
    document.body.appendChild(docFragment);
}

function getFontScale(min, max) {
    return max - min;
}

function countOfDiferentSizeElements(arr) {
    var count = 1;
    var len = arr.length;
    var currentCount = arr[0].count;
    for (var i = 1; i < len; i++) {
        if (arr[i].count != currentCount) {
            count++;
            currentCount = arr[i].count;
        }
    }

    return count;
}

function generateRandomNumber(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}
