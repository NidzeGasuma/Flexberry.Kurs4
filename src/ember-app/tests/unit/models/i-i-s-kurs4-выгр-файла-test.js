import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-kurs4-выгр-файла', 'Unit | Model | i-i-s-kurs4-выгр-файла', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-kurs4-выгр-файла',
    'model:i-i-s-kurs4-еди-изм',
    'model:i-i-s-kurs4-загр-файла',
    'model:i-i-s-kurs4-конв-файлы',
    'model:i-i-s-kurs4-конвертация',
    'model:i-i-s-kurs4-настр-конв',
    'model:i-i-s-kurs4-расширение',
    'model:i-i-s-kurs4-тч-загр',
    'model:i-i-s-kurs4-тч-настр',
    'model:i-i-s-kurs4-экс-файлы',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
