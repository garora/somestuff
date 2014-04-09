it('should connect the div', function () {
    var div = formElement.find('div');
    expect(div.css('display')).toBe('none');
});

it('should connect the button with the div', function () {
    var button = formElement.find('button');
    button.trigger('click');

    var div = formElement.find('div');
    expect(div.css('display')).toBe('');
});