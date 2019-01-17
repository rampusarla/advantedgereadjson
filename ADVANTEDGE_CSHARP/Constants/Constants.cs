using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADVANTEDGE_CSHARP.Constants
{
    public static class Constants
    {
        public static string SchemaJson = @"{
              'definitions': {},
              '$schema': 'http://json-schema.org/draft-07/schema#',
              '$id': 'http://example.com/root.json',
              'type': 'array',
              'title': 'The Root Schema',
              'items': {
                '$id': '#/items',
                'type': 'object',
                'title': 'The Items Schema',
                'required': [
                  'name',
                  'gender',
                  'age',
                  'pets'
                ],
                'properties': {
                  'name': {
                    '$id': '#/items/properties/name',
                    'type': 'string',
                    'title': 'The Name Schema',
                    'default': '',
                    'examples': [
                      'Bob'
                    ],
                    'pattern': '^(.*)$'
                  },
                  'gender': {
                    '$id': '#/items/properties/gender',
                    'type': 'string',
                    'title': 'The Gender Schema',
                    'default': '',
                    'examples': [
                      'Male'
                    ],
                    'pattern': '^(.*)$'
                  },
                  'age': {
                    '$id': '#/items/properties/age',
                    'type': 'integer',
                    'title': 'The Age Schema',
                    'default': 0,
                    'examples': [
                      23
                    ]
                  },
                  'pets': {
                    '$id': '#/items/properties/pets',
                    'type': [
                      'array', 
                      'null'
                    ],
                    'title': 'The Pets Schema',
                    'items': {
                      '$id': '#/items/properties/pets/items',
                      'type': 'object',
                      'title': 'The Items Schema',
                      'required': [
                        'name',
                        'type'
                      ],
                      'properties': {
                        'name': {
                          '$id': '#/items/properties/pets/items/properties/name',
                          'type': 'string',
                          'title': 'The Name Schema',
                          'default': '',
                          'examples': [
                            'Garfield'
                          ],
                          'pattern': '^(.*)$'
                        },
                        'type': {
                          '$id': '#/items/properties/pets/items/properties/type',
                          'type': 'string',
                          'title': 'The Type Schema',
                          'default': '',
                          'examples': [
                            'Cat'
                          ],
                          'pattern': '^(.*)$'
                        }
                      }
                    }
                  }
                }
              }
            }";
    }
}
