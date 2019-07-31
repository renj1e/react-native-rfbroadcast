
# react-native-rfbroadcast

## Getting started

`$ npm install react-native-rfbroadcast --save`

### Mostly automatic installation

`$ react-native link react-native-rfbroadcast`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-rfbroadcast` and add `RNRfbroadcast.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNRfbroadcast.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNRfbroadcastPackage;` to the imports at the top of the file
  - Add `new RNRfbroadcastPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-rfbroadcast'
  	project(':react-native-rfbroadcast').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-rfbroadcast/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-rfbroadcast')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNRfbroadcast.sln` in `node_modules/react-native-rfbroadcast/windows/RNRfbroadcast.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Rfbroadcast.RNRfbroadcast;` to the usings at the top of the file
  - Add `new RNRfbroadcastPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNRfbroadcast from 'react-native-rfbroadcast';

// TODO: What to do with the module?
RNRfbroadcast;
```
  