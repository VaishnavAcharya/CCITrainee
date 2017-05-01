var taskCount: number = 1;

function addTask() {
    
    var task: HTMLInputElement;
    task = <HTMLInputElement>document.getElementById("txtInputTask");
    var node= document.createElement("LI");
    var textnode = document.createTextNode(task.value);
    var nodeId = document.createAttribute("ID");
    nodeId.value = "Task" + taskCount;
    node.setAttributeNode(nodeId);

    var editButton = document.createElement("BUTTON");
    var editId = document.createAttribute("ID");
    editId.value = "btnEdit" + taskCount;
    editButton.setAttributeNode(editId);
    var editValue = document.createTextNode("Edit");
    editButton.appendChild(editValue);

    var deleteButton = document.createElement("BUTTON");
    var deleteId = document.createAttribute("ID");
    deleteId.value = "btnDelete" + taskCount;
    deleteButton.setAttributeNode(deleteId);
    var deleteOnclick = document.createAttribute("ONCLICK");
    deleteOnclick.value = "this.parentNode.parentNode.removeChild(this.parentNode)";
    deleteButton.setAttributeNode(deleteOnclick);
    var deleteValue = document.createTextNode("Delete");
    deleteButton.appendChild(deleteValue);

    node.appendChild(textnode);
    node.appendChild(editButton);
    node.appendChild(deleteButton);
    document.getElementById("List").appendChild(node);

    taskCount += 1;
}

//function deleteTask() {
//    alert(this.parentNode.nodeName);
//}

window.onload = function () {
    document.getElementById("btnAdd").addEventListener("click", function () { addTask() });

    //document.getElementById("btnDelete").addEventListener("click", function () { deleteTask() });
}


