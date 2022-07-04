# Change Log

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/)
and this project adheres to [Semantic Versioning](http://semver.org/).

## [3.0.0] - 2022-03-07

### Added

- Support for TWS API 10.16
- Some messages are now using decimal for more precision
- Created IBClientSocket and IEClientSocket classes to faciliate unit tests
- Created IBClientException class
- GetScannerDataAsync will throw on API errors

### Changed

- Broken down client into multiple partial classes for simplified maintenance

## [2.0.0] - 2020-12-14

### Added

- Support for TWS API 9.81
