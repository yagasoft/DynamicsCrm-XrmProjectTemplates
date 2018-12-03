# DynamicsCrm-XrmProjectTemplates

[![Join the chat at https://gitter.im/yagasoft/DynamicsCrm-XrmProjectTemplates](https://badges.gitter.im/yagasoft/DynamicsCrm-XrmProjectTemplates.svg)](https://gitter.im/yagasoft/DynamicsCrm-XrmProjectTemplates?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

### Version: 2.8.3
---

A Visual Studio plugin that makes it easier to perform unit/intergration-hybrid testing for CRM plugins. It also includes a few templates for plugin and step projects for fast start.

### Features

+ Create ready-to-code plugin and step project with the click of a mouse
  + Includes logging, initialisation, and error handling
+ Create a 'hybrid' test to easily debug the plugin code
  + Connects to CRM as if plugins are registered
  + Supports rollback of actions done in CRM by the test
  + Supports disabling plugin steps during testing to get more realistic results

### Credits

  + Wael Hamze and Ramon Tebar
	+ Base code
	+ https://archive.codeplex.com/?p=xrmtestframework
	+ My work:
		+ Added Hybrid testing module
		+ Added plugin project templates
		
### Changes

#### _v2.8.3 (2018-12-03)_
+ Changed: v8 plugin template now uses the NuGet Common.cs package
#### _v2.8.2 (2018-11-27)_
+ Changed: v9 plugin template now uses the NuGet Common.cs package
#### _v2.8.1 (2018-08-27)_
+ Changed: moved common parameters to the class level (static)
+ Improved: plugin steps toggle is now based on a name pattern to be more specific
+ Fixed: CRM service access hangs tests
#### _v2.7.9 (2018-08-02)_
+ Fixed: pool init error
#### _v2.7.8 (2018-07-30)_
+ Fixed: incorrect reference error

---
**Copyright &copy; by Ahmed el-Sawalhy ([Yagasoft](http://yagasoft.com))** -- _GPL v3 Licence_
