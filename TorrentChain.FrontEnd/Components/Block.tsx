import { BlockModel } from 'Model/BlockModel';
import * as React from 'react';

interface Props {
  block: BlockModel;
}

export class Block extends React.Component<Props> {
  private renderTorrentInfo() {
    const { block } = this.props;
    if (!block.torrentInfo) {
      return null;
    }

    return (
      <div>
        <div>
          <span className="block-info">Magnet Link: </span>
          <a href={block.magnetLink}>{block.magnetLink}</a>
        </div>
        <div>
          <span className="block-info">Number Of Pieces: </span>
          {block.torrentInfo.numberOfPieces}
        </div>
        <div>
          <span className="block-info">Display Name: </span>
          {block.torrentInfo.displayName}
        </div>
        <div>
          <span className="block-info">Trackers: </span>
          {JSON.stringify(block.torrentInfo.trackers)}
        </div>
      </div>
    );
  }

  private renderBlockInfo() {
    const { block } = this.props;
    return (
      <div>
        <div>
          <span className="block-info">Index: </span>
          {block.index}
        </div>
        <div>
          <span className="block-info">Hash: </span>
          {block.hash}
        </div>
        <div>
          <span className="block-info">Previous Hash: </span>
          {block.previousHash}
        </div>
        <div>
          <span className="block-info">Timestamp: </span>
          {block.timeStamp}
        </div>
        {this.renderTorrentInfo()}
      </div>
    );
  }

  private renderArrow() {
    if (!this.props.block.previousHash) {
      return null;
    }

    return <div>^</div>;
  }

  public render() {
    return (
      <>
        {this.renderArrow()}
        <div className="block-container">{this.renderBlockInfo()}</div>
      </>
    );
  }
}
