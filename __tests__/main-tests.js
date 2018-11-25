describe('Blazor', () => {
    beforeAll(async () => {
        await page.goto('http:localhost:5000', { waitUntil : 'networkidle0' } );
    });

    it('should display "Hello, world!" text on page', async () => {
        await expect(page).toMatch('Hello, world!');
    });

    
    it('should navigate to counter page', async () => {
        await page.click('a[href=counter]');
        await expect(page).toMatch('Current count: 0');

        await page.click('button.btn');
        await expect(page).toMatch('Current count: 1');
    });
});