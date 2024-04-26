# Appium Test Suite

This repository contains a test suite implemented in C# using the Appium framework with SpecFlow for automating mobile Android and hybrid apps.

## Getting Started

To use this framework and create your own BDD (Behavior-Driven Development) project based on SpecFlow, follow these steps:

1. Clone the repository to your local machine.
2. Add your BDD project by creating the following folders:
   - Features
   - Steps
   - Pages
3. Inherit the `BasePage` class in your Steps and Pages, and utilize the Page Object Model (POM) and PageFactory for efficient test development.

## Configuration

To configure your environment settings, update the `App.config` file under the `TestConfiguration/testSettings` tag. Here's an example:

```xml
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
