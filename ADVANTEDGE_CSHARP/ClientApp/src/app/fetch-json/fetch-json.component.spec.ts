import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FetchJsonComponent } from './fetch-json.component';

describe('FetchJsonComponent', () => {
  let component: FetchJsonComponent;
  let fixture: ComponentFixture<FetchJsonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FetchJsonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FetchJsonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
