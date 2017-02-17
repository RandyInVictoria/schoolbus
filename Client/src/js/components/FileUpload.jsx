import React from 'react';
import { Button, Glyphicon, OverlayTrigger, Tooltip, ProgressBar, Alert } from 'react-bootstrap';

import { request, buildApiPath } from '../utils/http';

const FILE_UPLOAD_PATH = '/test-file-upload';

var FileUpload = React.createClass({
  propTypes: {
    id: React.PropTypes.string,
    className: React.PropTypes.string,
    label: React.PropTypes.string,
    mimeTypes: React.PropTypes.array,
    onFilesSelected: React.PropTypes.func,
  },

  getInitialState() {
    return {
      files: [],
      uploadInProgress: false,
      percentUploaded: null,
      fileUploadError: null,
    };
  },

  filesPicked(e) {
    var files = this.state.files.slice();
    files.push.apply(files, e.target.files);
    this.setState({ files: files, percentUploaded: null });

    if(this.props.onFilesSelected) {
      this.props.onFilesSelected(e.target.files);
    }
  },

  uploadFiles() {
    var files = this.state.files;
    this.setState({ uploadInProgress: true, percentUploaded: 0, files: [] });

    var options = {
      method: 'POST',
      files: files,
      onUploadProgress: (percentComplete) => {
        this.setState({ percentUploaded: percentComplete });
      },
    };

    this.uploadPromise = request(buildApiPath(FILE_UPLOAD_PATH), options).then(() => {
      this.setState({ uploadInProgress: false, percentUploaded: null });
    }, (err) => {
      this.setState({ uploadInProgress: false, fileUploadError: err });
    });
  },

  reset() {
    this.setState(this.getInitialState());
  },

  render() {
    var classNames = [ 'file-upload' ];

    if(this.props.className) {
      classNames.push(this.props.className);
    }

    if(this.state.fileUploadError) {
      classNames.push('file-upload-error');
    }

    var filePicker, fileUploadButton, clearFilesButton, uploadProgressBar;
    var error;
    if(!this.state.fileUploadError) {
      if(!this.state.uploadInProgress) {
        filePicker = <label>
          <div className="btn btn-default">
            <Glyphicon glyph="folder-open" />{this.props.label}
          </div>
          <input type="file" multiple onChange={this.filesPicked}/>
        </label>;
      }

      if(!this.state.uploadInProgress) {
        var uploadTooltip = <Tooltip id="files-to-upload-tooltip">
          Upload {this.state.files.length} files
        </Tooltip>;

        fileUploadButton = <OverlayTrigger placement="top" overlay={uploadTooltip}>
          <Button onClick={this.uploadFiles} disabled={this.state.files.length === 0}>
            <Glyphicon glyph="upload" />
            Upload {this.state.files.length} Files
          </Button>
        </OverlayTrigger>;

        var clearFilesTooltip = <Tooltip id="files-to-upload-tooltip">
          Remove {this.state.files.length} files
        </Tooltip>;

        clearFilesButton = <OverlayTrigger placement="top" overlay={clearFilesTooltip}>
          <Button onClick={this.reset} disabled={this.state.files.length === 0}>
              <Glyphicon glyph="remove-sign" />
          </Button>
        </OverlayTrigger>;
      } else {
        uploadProgressBar = <ProgressBar now={this.state.percentUploaded} label={`${this.state.percentUploaded}%`} />;
      }
    } else {
      error = <OverlayTrigger placement="top" overlay={<Tooltip id="file-upload-error-tooltip">{String(this.state.fileUploadError)}</Tooltip>}>
        <p className="file-upload-error-message" onClick={this.reset}>Upload Error<Glyphicon glyph="remove"/></p>
      </OverlayTrigger>;
    }

    return <div id={this.props.id} className={classNames.join(' ')}>
        {filePicker}
        {clearFilesButton}
        {fileUploadButton}
        {uploadProgressBar}
        {error}
      </div>;
  },
});


export default FileUpload;
