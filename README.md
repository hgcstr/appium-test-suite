# AppiumTestApp
Appium framework in C# with SpecFlow for automate mobile Android and hybrid apps

You can clone and add your BDD project based on specflow creating folders for:
-Features
-Steps
-Pages
(Don't forget to inherit the BasePage clase in your Steps and Pages, and use POM and PageFactory)

To configure your environment settings you can do it by the App.config file under the TestConfiguration/testSettings tag.
Example:
  <TestConfiguration>
    <testSettings>
      <testSetting 
        name="staging" 
        autPath ="C:\MyPath\app-release.apk" 
        platformName="Android" 
        deviceName="emulator-5554" 
        chromeDriverPath="C:\ChromeDriver\chromedriver.exe" 
        appPackage="com.MyApp"
        nodePath="C:\Program Files\nodejs\node.exe"
        appiumJSPath="C:\Users\MyUser\AppData\Roaming\npm\node_modules\appium\build\lib\main.js"
        />
    </testSettings>
  </TestConfiguration>



