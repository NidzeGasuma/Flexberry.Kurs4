import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-kurs4-конвертация', 'Unit | Serializer | i-i-s-kurs4-конвертация', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-kurs4-конвертация',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-kurs4-тип-атр',

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
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
