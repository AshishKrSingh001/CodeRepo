 int noOfNonZeroElement = countNonZeroElement(sparse);
    struct B b[noOfNonZeroElement];
    calculateBMatrix(sparse, b);
    printBMatrix(b, noOfNonZeroElement);